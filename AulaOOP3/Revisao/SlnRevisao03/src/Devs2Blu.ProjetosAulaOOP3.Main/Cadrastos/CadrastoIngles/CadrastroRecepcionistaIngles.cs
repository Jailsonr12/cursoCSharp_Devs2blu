using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos.Interface;
using Devs2Blu.ProjetosAulaOOP3.Main.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos {
    public class CadrastroRecepcionistaIngles : IMenuCadrasto {

        public CadrastroRecepcionistaIngles() {

        }

        private void ListarRecepcionistaingles() {

            Console.Clear();

            foreach (Recepcionista recepcionista in Program.Mock.ListRecepcionista) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine($"Receptionist {recepcionista.CodigoRecepcionista}");
                Console.WriteLine($"Name: {recepcionista.Nome}");
                Console.WriteLine($"ITIN: {recepcionista.CGCCPF}");
                Console.WriteLine($"Sector: {recepcionista.Setor}");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

            }
            Console.WriteLine("Type anything to exit");
            Console.ReadLine();

        }
        private void CadrastrarRecepcionistaIngles(Recepcionista novoRecepcionista) {

            Program.Mock.ListRecepcionista.Add(novoRecepcionista);

        }

        private void AlterarRecepcionista(Recepcionista recepcionista) {
            var pact = Program.Mock.ListRecepcionista.Find(p => p.CodigoRecepcionista == recepcionista.CodigoRecepcionista);
            int index = Program.Mock.ListRecepcionista.IndexOf(pact);
            Program.Mock.ListRecepcionista[index] = recepcionista;
        }
        private void ExcluirRecepcionista(Recepcionista recepcionista) {

            Program.Mock.ListRecepcionista.Remove(recepcionista);
        }

        private void ListarRecepcionistasByCodeAndName() {

            foreach (Recepcionista recepcionista in Program.Mock.ListRecepcionista) {
                Console.WriteLine($"| {recepcionista.CodigoRecepcionista} - {recepcionista.Nome} ");
            }
            Console.WriteLine("\n");
        }

        public Int32 MenuCadastro() {
            Int32 opcao;
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("----- Receptionist Registration                       -----");
            Console.WriteLine("----- 1- Receptionist List                            -----");
            Console.WriteLine("----- 2- Receptionist Registration                    -----");
            Console.WriteLine("----- 3- Change Receptionist                          -----");
            Console.WriteLine("----- 4- Delete Provider                              -----");
            Console.WriteLine("----- 0- EXIT                                         -----");
            Console.WriteLine("----- Enter the number of the option you want to see  -----");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Int32.TryParse(Console.ReadLine(), out opcao);

            return opcao;
        }

        public void Lista() {
            ListarRecepcionistaingles();

        }



        public void Cadrastrar() {
            Console.Clear();
            Recepcionista recepcionista = new Recepcionista();

            Random rd = new Random();
            recepcionista.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            recepcionista.CodigoRecepcionista = Int32.Parse($"{recepcionista.Codigo}{rd.Next(100, 999)}");

            Console.WriteLine("Enter the name of the Receptionist: ");
            recepcionista.Nome = Console.ReadLine();

            Console.WriteLine("Enter the Receptionist's CPF: ");
            recepcionista.CGCCPF = Console.ReadLine();

            Console.WriteLine("Inform the receptionist sector: ");
            recepcionista.Setor = Console.ReadLine();

            CadrastrarRecepcionistaIngles(recepcionista);
        }
    

        public void Alterar() {
            Console.Clear();
            Recepcionista Recepcionista;
            int codigoRecepcionista;

            Console.WriteLine("Inform the Receptionist that you want to change: ");
            ListarRecepcionistasByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);

            Recepcionista = Program.Mock.ListRecepcionista.Find(p => p.CodigoRecepcionista == codigoRecepcionista);

            string opcaoAlterar;
            bool alterar = true;

            do {
                Console.WriteLine($"Receptionist: {Recepcionista.Codigo}/{Recepcionista.CodigoRecepcionista} | Nome: {Recepcionista.Nome} | CPF: {Recepcionista.CGCCPF} | Sector: {Recepcionista.Setor}");
                Console.WriteLine("Which field do you want to change?");
                Console.WriteLine("01 - Name | 02 - ITIN | 03 - Setor | 00 - Sair");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar){
                    case "01":
                        Console.WriteLine("Enter a new name: ");
                        Recepcionista.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Enter a new ITIN: ");
                        Recepcionista.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Enter a new Sector: ");
                        Recepcionista.Setor = Console.ReadLine();
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

            AlterarRecepcionista(Recepcionista);
        }

        public void Excluir() {
            Console.Clear();
            Recepcionista recepcionista;
            int codigorecepcionista1;
            int codigorecepcionista2;

            Console.WriteLine("| List of Receptionists: ");
            ListarRecepcionistasByCodeAndName();
            Console.WriteLine("Enter the code of the receptionist you want to delete: ");
            Int32.TryParse(Console.ReadLine(), out codigorecepcionista1);
            Console.WriteLine("Confirm the receptionist code again: ");
            Int32.TryParse(Console.ReadLine(), out codigorecepcionista2);

            recepcionista = Program.Mock.ListRecepcionista.Find(r => r.CodigoRecepcionista == codigorecepcionista1 && r.CodigoRecepcionista == codigorecepcionista2);

            if (codigorecepcionista1 == codigorecepcionista2) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("Receptionists Deleted Successfully                    -----");
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

            ExcluirRecepcionista(recepcionista);
        }
    }
}
