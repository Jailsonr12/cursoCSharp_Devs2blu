using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos.Interface;
using Devs2Blu.ProjetosAulaOOP3.Main.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos {
    public class CadrastroRecepcionista : IMenuCadrasto {

        public CadrastroRecepcionista() {

        }

        private void ListarRecepcionista() {

            Console.Clear();

            foreach (Recepcionista recepcionista in Program.Mock.ListRecepcionista) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine($"Recepcionista: {recepcionista.CodigoRecepcionista}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"CPF: {recepcionista.CGCCPF}");
                Console.WriteLine($"Setor: {recepcionista.Setor}");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

            }
            Console.WriteLine("Digite qualquer coisa para sair");
            Console.ReadLine();

        }
        private void CadrastrarRecepcionista(Recepcionista novoRecepcionista) {

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
            Console.WriteLine("----- Cadastro de Recepcionista                       -----");
            Console.WriteLine("----- 1 - Lista de Recepcionista                       -----");
            Console.WriteLine("----- 2 - Cadastro de Recepcionista                    -----");
            Console.WriteLine("----- 3 - Alterar  Recepcionista                       -----");
            Console.WriteLine("----- 4 - Exluir  Fornecedor                          -----");
            Console.WriteLine("----- 0 - SAIR                                         -----");
            Console.WriteLine("----- Digite o número da opção que deseja ver         -----");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Int32.TryParse(Console.ReadLine(), out opcao);

            return opcao;
        }

        public void Lista() {
            ListarRecepcionista();

        }



        public void Cadrastrar() {
            Console.Clear();
            Recepcionista recepcionista = new Recepcionista();

            Random rd = new Random();
            recepcionista.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            recepcionista.CodigoRecepcionista = Int32.Parse($"{recepcionista.Codigo}{rd.Next(100, 999)}");

            Console.WriteLine("Informe o nome da Recepcionista: ");
            recepcionista.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF da Recepcionista: ");
            recepcionista.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o setor da Recepcionista: ");
            recepcionista.Setor = Console.ReadLine();

            CadrastrarRecepcionista(recepcionista);
        }


        public void Alterar() {
            Console.Clear();
            Recepcionista Recepcionista;
            int codigoRecepcionista;

            Console.WriteLine("Informe o Recepcionista que deseja alterar: ");
            ListarRecepcionistasByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);

            Recepcionista = Program.Mock.ListRecepcionista.Find(p => p.CodigoRecepcionista == codigoRecepcionista);

            string opcaoAlterar;
            bool alterar = true;

            do {
                Console.WriteLine($"Recepcionista: {Recepcionista.Codigo}/{Recepcionista.CodigoRecepcionista} | Nome: {Recepcionista.Nome} | CPF: {Recepcionista.CGCCPF} | Setor: {Recepcionista.Setor}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 - Setor | 00 - Sair");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar) {
                    case "01":
                        Console.WriteLine("Informe um novo nome: ");
                        Recepcionista.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF: ");
                        Recepcionista.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo setor: ");
                        Recepcionista.Setor = Console.ReadLine();
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

            AlterarRecepcionista(Recepcionista);
        }

        public void Excluir() {
            Console.Clear();
            Recepcionista recepcionista;
            int codigorecepcionista1;
            int codigorecepcionista2;

            Console.WriteLine("| Lista de Recepcionistas: ");
            ListarRecepcionistasByCodeAndName();
            Console.WriteLine("Informe o código do recepcionista que deseja excluir: ");
            Int32.TryParse(Console.ReadLine(), out codigorecepcionista1);
            Console.WriteLine("Confirme novamente o codigo do recepcionista: ");
            Int32.TryParse(Console.ReadLine(), out codigorecepcionista2);

            recepcionista = Program.Mock.ListRecepcionista.Find(r => r.CodigoRecepcionista == codigorecepcionista1 && r.CodigoRecepcionista == codigorecepcionista2);

            if (codigorecepcionista1 == codigorecepcionista2) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("Recepcionista Exluido com sucesso                     -----");
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

            ExcluirRecepcionista(recepcionista);
        }
    }
}
