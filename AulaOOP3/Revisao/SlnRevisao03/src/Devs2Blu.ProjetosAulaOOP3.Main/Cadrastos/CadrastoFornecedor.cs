using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos.Interface;
using Devs2Blu.ProjetosAulaOOP3.Main.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos {
    public class CadrastoFornecedor : IMenuCadrasto {
        public CadrastoFornecedor() {
        }

        private void ListarForcedor() {

            Console.Clear();

            foreach (Fornecedor fornecedor in Program.Mock.ListFornecedor) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine($"Forcederor: {fornecedor.CodigoFornecedor}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"CPF: {fornecedor.CGCCPF}");
                Console.WriteLine($"Mercadiria: {fornecedor.TipoFornecedor}");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

            }
            Console.WriteLine("Digite qualquer coisa para sair");
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
            Console.WriteLine("----- Cadastro de Fornecedor                          -----");
            Console.WriteLine("----- 1 - Lista de Fornecedor                          -----");
            Console.WriteLine("----- 2 - Cadastro de Fornecedor                       -----");
            Console.WriteLine("----- 3 - Alterar  Fornecedor                         -----");
            Console.WriteLine("----- 4 - Excluir  Fornecedor                          -----");
            Console.WriteLine("----- 0 - SAIR                                         -----");
            Console.WriteLine("----- Digite o número da opção que deseja ver         -----");
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

            Console.WriteLine("Informe o nome do fornecedor: ");
            fornecedor.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do fornecedor: ");
            fornecedor.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe a mercadoria do fornecedor: ");
            fornecedor.TipoFornecedor = Console.ReadLine();

            CadrastrarFornecedor(fornecedor);
        }



        public void Alterar() {
            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor;

            Console.WriteLine("Informe o Fornecedor que deseja alterar: ");
            ListarFornecedorsByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

            fornecedor = Program.Mock.ListFornecedor.Find(p => p.CodigoFornecedor == codigoFornecedor);

            string opcaoAlterar;
            bool alterar = true;

            do {
                Console.WriteLine($"Fornecedor: {fornecedor.Codigo}/{fornecedor.CodigoFornecedor} | Nome: {fornecedor.Nome} | CPF: {fornecedor.CGCCPF} | Mercadoria: {fornecedor.TipoFornecedor}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 - Mercadoria | 00 - Sair");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar) {
                    case "01":
                        Console.WriteLine("Informe um novo nome: ");
                        fornecedor.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF: ");
                        fornecedor.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe uma nova Mercadoria: ");
                        fornecedor.TipoFornecedor = Console.ReadLine();
                        break;

                    default:
                        alterar = false;
                        break;
                }

                if (alterar) {
                    Console.Clear();
                    Console.WriteLine("Dado alterado com sucesso!");
                }
            } while (alterar);

            AlterarFornecedor(fornecedor);
        }



        public void Excluir() {
            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor1;
            int codigoFornecedor2;

            Console.WriteLine("| Lista de Fornecedor");
            ListarFornecedorsByCodeAndName();
            Console.WriteLine("Informe o codigo de qual fornecedor que deseja excluir: ");
            Int32.TryParse(Console.ReadLine(), out codigoFornecedor1);
            Console.WriteLine("Confirme novamente o codigo do fornecedor: ");
            Int32.TryParse(Console.ReadLine(), out codigoFornecedor2);

            fornecedor = Program.Mock.ListFornecedor.Find(p => p.CodigoFornecedor == codigoFornecedor1 && p.CodigoFornecedor == codigoFornecedor2);

            if (codigoFornecedor1 == codigoFornecedor2) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("Fornecedor Exluido com sucesso                        -----");
                Console.WriteLine("Aperte qualquer tecla para sair                       -----");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("********          Aconteceu um ERRO           ********-----");
                Console.WriteLine("Aperte qualquer tecla para sair                       -----");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.ReadLine();
            }

            ExcluirFornecedor(fornecedor);


        }
    }


}
