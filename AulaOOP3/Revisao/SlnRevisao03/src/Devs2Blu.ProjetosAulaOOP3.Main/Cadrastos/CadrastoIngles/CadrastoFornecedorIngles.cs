using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos.Interface;
using Devs2Blu.ProjetosAulaOOP3.Main.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos {
    public class CadrastoFornecedorIngles : IMenuCadrasto {
        public CadrastoFornecedorIngles() {
        }

        private void ListarForcedor() {

            Console.Clear();

            foreach (Fornecedor fornecedor in Program.Mock.ListFornecedor) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine($"Forcederor: {fornecedor.CodigoFornecedor}");
                Console.WriteLine($"Name: {fornecedor.Nome}");
                Console.WriteLine($"ITIN: {fornecedor.CGCCPF}");
                Console.WriteLine($"Merchandise {fornecedor.TipoFornecedor}");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

            }
            Console.WriteLine("Type anything to exit");
            Console.ReadLine();

        }
        //Ok
        private void CadrastrarFornecedor(Fornecedor novoFornecedor) {

            Program.Mock.ListFornecedor.Add(novoFornecedor);

        }

        private void AlterarFornecedor(Fornecedor fornecedor) {
            var pact = Program.Mock.ListFornecedor.Find(p => p.CodigoFornecedor == fornecedor.CodigoFornecedor);
            int index = Program.Mock.ListFornecedor.IndexOf(pact);
            Program.Mock.ListFornecedor[index] = fornecedor;
        }

        private void ExcluirFornecedor(Fornecedor fornecedor) {

            Program.Mock.ListFornecedor.Remove(fornecedor);
        }
        private void ListarFornecedorsByCodeAndName() {

            foreach (Fornecedor fornecedor in Program.Mock.ListFornecedor) {
                Console.WriteLine($"| {fornecedor.CodigoFornecedor} - {fornecedor.Nome} ");
            }
            Console.WriteLine("\n");
        }

        public Int32 MenuCadastro() {
            Int32 opcao;
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("----- Supplier Registration                           -----");
            Console.WriteLine("----- 1 - Vendor List                                 -----");
            Console.WriteLine("----- 2 - Supplier Registration                       -----");
            Console.WriteLine("----- 3 - Change Provider                             -----");
            Console.WriteLine("----- 4 - Delete Provider                             -----");
            Console.WriteLine("----- 0 - EXIT                                        -----");
            Console.WriteLine("----- Enter the number of the option you want to see  -----");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Int32.TryParse(Console.ReadLine(), out opcao);

            return opcao;
        }

        public void Lista() {

            ListarForcedor();

        }
        public void Cadrastrar() {
            Console.Clear();
            Fornecedor fornecedor = new Fornecedor();

            Random rd = new Random();
            fornecedor.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            fornecedor.CodigoFornecedor = Int32.Parse($"{fornecedor.Codigo}{rd.Next(100, 999)}");

            Console.WriteLine("Enter the name of the supplier: ");
            fornecedor.Nome = Console.ReadLine();

            Console.WriteLine("Enter the supplier's ITIN: ");
            fornecedor.CGCCPF = Console.ReadLine();

            Console.WriteLine("Inform the supplier's merchandise: ");
            fornecedor.TipoFornecedor = Console.ReadLine();

            CadrastrarFornecedor(fornecedor);
        }



        public void Alterar() {
            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor;

            Console.WriteLine("Inform the Supplier you want to change: ");
            ListarFornecedorsByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

            fornecedor = Program.Mock.ListFornecedor.Find(p => p.CodigoFornecedor == codigoFornecedor);

            string opcaoAlterar;
            bool alterar = true;

            do {
                Console.WriteLine($"Provider: {fornecedor.Codigo}/{fornecedor.CodigoFornecedor} | Name: {fornecedor.Nome} | ITIN: {fornecedor.CGCCPF} | Merchandise: {fornecedor.TipoFornecedor}");
                Console.WriteLine("Which field do you want to change?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 - Mercadoria | 00 - Sair");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar) {
                    case "01":
                        Console.WriteLine("Enter a new name: ");
                        fornecedor.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Enter a new ITIN: ");
                        fornecedor.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Report a new Good: ");
                        fornecedor.TipoFornecedor = Console.ReadLine();
                        break;

                    default:
                        alterar = false;
                        break;
                }

                if (alterar) {
                    Console.Clear();
                    Console.WriteLine("Data successfully changed!");
                }
            } while (alterar);

            AlterarFornecedor(fornecedor);
        }



        public void Excluir() {
            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor1;
            int codigoFornecedor2;

            Console.WriteLine("| Supplier List");
            ListarFornecedorsByCodeAndName();
            Console.WriteLine("Inform the code of which supplier you want to exclude: ");
            Int32.TryParse(Console.ReadLine(), out codigoFornecedor1);
            Console.WriteLine("Confirm the supplier code again: ");
            Int32.TryParse(Console.ReadLine(), out codigoFornecedor2);

            fornecedor = Program.Mock.ListFornecedor.Find(p => p.CodigoFornecedor == codigoFornecedor1 && p.CodigoFornecedor == codigoFornecedor2);

            if (codigoFornecedor1 == codigoFornecedor2) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("Supplier Deleted Successfully                         -----");
                Console.WriteLine("Press any key to exit                                 -----");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("********        AN ERROR HAS OCCURRED         ********-----");
                Console.WriteLine("Press any key to exit                                 -----");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.ReadLine();
            }

            ExcluirFornecedor(fornecedor);


        }
    }


}
