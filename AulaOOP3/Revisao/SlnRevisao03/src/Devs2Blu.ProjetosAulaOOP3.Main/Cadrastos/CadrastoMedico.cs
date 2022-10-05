using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAulaOOP3.Main.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAulaOOP3.Main.Utils;
using Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos.Interface;

namespace Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos {
    public class CadrastoMedico : IMenuCadrasto {
        public CadrastoMedico() {

        }
        private void ListarMedicosByCodeAndName() {

            foreach (Medico medico in Program.Mock.ListMedico) {
                Console.WriteLine($"| {medico.CodigoMedico} - {medico.Nome} ");
            }
            Console.WriteLine("\n");
        }


        public void ListarMedico() {

            Console.Clear();

            foreach (Medico medico in Program.Mock.ListMedico) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine($"Medico: {medico.CodigoMedico}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"CPF: {medico.CGCCPF}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

            }
            Console.WriteLine("Digite qualquer coisa para sair");
            Console.WriteLine();
        }
        private void CadrastrarMedico(Medico novoMedico) {

            Program.Mock.ListMedico.Add(novoMedico);

        }

        private void AlterarMedico(Medico medico) {
            var pact = Program.Mock.ListMedico.Find(m => m.CodigoMedico == medico.CodigoMedico);
            int index = Program.Mock.ListMedico.IndexOf(pact);
            Program.Mock.ListMedico[index] = medico;
        }


        public Int32 MenuCadastro() {
            Int32 opcao;
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("----- Cadastro de Medico                              -----");
            Console.WriteLine("----- 1 - Lista de Medico                             -----");
            Console.WriteLine("----- 2 - Cadastro de Medico                          -----");
            Console.WriteLine("----- 3 - Alterar  Medico                             -----");
            Console.WriteLine("----- 4 - Exluir  Medico                              -----");
            Console.WriteLine("----- 0 - SAIR                                        -----");
            Console.WriteLine("----- Digite o número da opção que deseja ver         -----");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Int32.TryParse(Console.ReadLine(), out opcao);

            return opcao;
        }
        public void Lista() {

            ListarMedico();
        }


        public void Cadrastrar() {

            Console.Clear();
            Medico medico = new Medico();

            Random rd = new Random();
            medico.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            medico.CodigoMedico = Int32.Parse($"{medico.Codigo}{rd.Next(100, 999)}");

            Console.WriteLine("Informe o nome do Medico: ");
            medico.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do Medico: ");
            medico.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o CRM do Medico: ");
            medico.CRM = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o especialidade do Medico: ");
            medico.Especialidade = Console.ReadLine();

            CadrastrarMedico(medico);
        }

        public void Alterar() {

            Console.Clear();
            Medico medico;
            int codigoMedico;

            Console.WriteLine("Informe o Medico que deseja alterar: ");
            ListarMedicosByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoMedico);

            medico = Program.Mock.ListMedico.Find(p => p.CodigoMedico == codigoMedico);

            string opcaoAlterar;
            bool alterar = true;

            do {
                Console.WriteLine($"Medico: {medico.Codigo}/{medico.CodigoMedico} | Nome: {medico.Nome} | CPF: {medico.CGCCPF} | Especialidade: {medico.Especialidade}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 - Especialidade |04 - CRM | 00 - Sair");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar) {
                    case "01":
                        Console.WriteLine("Informe um novo nome: ");
                        medico.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF: ");
                        medico.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo especialidade: ");
                        medico.Especialidade = Console.ReadLine();
                        break;
                    case "04":
                        Console.WriteLine("Informe um novo CRM: ");
                        medico.CRM = Int32.Parse(Console.ReadLine());
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

            AlterarMedico(medico);
        }

        public void Excluir() {

            Console.Clear();
            Medico medico;
            int codigoMedico1;
            int codigoMedico2;

            Console.WriteLine("| Lista de Medicos: ");
            ListarMedicosByCodeAndName();
            Console.WriteLine("Informe o código do Medico que deseja excluir: ");
            Int32.TryParse(Console.ReadLine(), out codigoMedico1);
            Console.WriteLine("Confirme novamente o codigo do paciente: ");
            Int32.TryParse(Console.ReadLine(), out codigoMedico2);

            medico = Program.Mock.ListMedico.Find(m => m.CodigoMedico == codigoMedico1 && m.CodigoMedico == codigoMedico2);

            if (codigoMedico1 == codigoMedico2) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("MedicoExluido com sucesso                             -----");
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



            ExcluirMedico(medico);

        }

        private void ExcluirMedico(Medico medico) {

            Program.Mock.ListMedico.Remove(medico);
        }


    }
}
