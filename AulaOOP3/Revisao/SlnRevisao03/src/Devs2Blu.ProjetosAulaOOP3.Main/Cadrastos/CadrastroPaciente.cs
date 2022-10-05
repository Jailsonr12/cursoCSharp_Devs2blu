using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos.Interface;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAulaOOP3.Main.Utils;
using Devs2Blu.ProjetosAulaOOP3.Main.Utils.Enums;


namespace Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos {
    public class CadrastroPaciente : IMenuCadrasto {
        public CadrastroPaciente() {

        }


        private void ListarPacientes() {

            Console.Clear();

            foreach (Paciente paceinte in Program.Mock.ListPacientes) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine($"Paciente: {paceinte.CodigoPaciente}");
                Console.WriteLine($"Nome: {paceinte.Nome}");
                Console.WriteLine($"CPF: {paceinte.CGCCPF}");
                Console.WriteLine($"Convenio: {paceinte.Convenio}");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

            }
            Console.WriteLine("Digite qualquer coisa para sair");
            Console.ReadLine();

        }
        
        private void CadrastrarPaciente(Paciente novoPaciente) {

            Program.Mock.ListPacientes.Add(novoPaciente);

        }

        private void AlterarPaciente(Paciente paciente) {
            var pact = Program.Mock.ListPacientes.Find(p => p.CodigoPaciente == paciente.CodigoPaciente);
            int index = Program.Mock.ListPacientes.IndexOf(pact);
            Program.Mock.ListPacientes[index] = paciente;
        }
        private void ExcluirPaciente(Paciente paciente) {

            Program.Mock.ListPacientes.Remove(paciente);
        }
        private void ListarPacientesByCodeAndName() {

            foreach (Paciente paciente in Program.Mock.ListPacientes) {
                Console.WriteLine($"| {paciente.CodigoPaciente} - {paciente.Nome} ");
            }
            Console.WriteLine("\n");
        }


        #region FACEDE
        public Int32 MenuCadastro() {
            Int32 opcao;
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("----- Cadastro de Paciente                            -----");
            Console.WriteLine("----- 1 - Lista de Paciente                           -----");
            Console.WriteLine("----- 2 - Cadastro de Paciente                        -----");
            Console.WriteLine("----- 3 - Alterar  Paciente                           -----");
            Console.WriteLine("----- 4 - Excluir  Paciente                           -----");
            Console.WriteLine("----- 0 - SAIR                                        -----");
            Console.WriteLine("----- Digite o número da opção que deseja ver         -----");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Int32.TryParse(Console.ReadLine(), out opcao);

            return opcao;
        }

        public void Lista() {

            ListarPacientes();
        }


        public void Cadrastrar() {

            Console.Clear();
            Paciente paciente = new Paciente();

            Random rd = new Random();
            paciente.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            paciente.CodigoPaciente = Int32.Parse($"{paciente.Codigo}{rd.Next(100, 999)}");

            Console.WriteLine("Informe o nome do paciente: ");
            paciente.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do paciente: ");
            paciente.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o convênio do paciente: ");
            paciente.Convenio = Console.ReadLine();

            CadrastrarPaciente(paciente);
        }

        public void Alterar() {

            Console.Clear();
            Paciente paciente;
            int codigoPaciente;

            Console.WriteLine("Informe o paciente que deseja alterar: ");
            ListarPacientesByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoPaciente);

            paciente = Program.Mock.ListPacientes.Find(p => p.CodigoPaciente == codigoPaciente);

            string opcaoAlterar;
            bool alterar = true;

            do {
                Console.WriteLine($"Paciente: {paciente.Codigo}/{paciente.CodigoPaciente} | Nome: {paciente.Nome} | CPF: {paciente.CGCCPF} | Convênio: {paciente.Convenio}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 - Convênio | 00 - Sair");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar){
                    case "01":
                        Console.WriteLine("Informe um novo nome: ");
                        paciente.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF: ");
                        paciente.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo convênio: ");
                        paciente.Convenio = Console.ReadLine();
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

            AlterarPaciente(paciente);
        }

        public void Excluir() {

            Console.Clear();
            Paciente paciente;
            int codigopaciente1;
            int codigopaciente2;

            Console.WriteLine("*** Lista de Pacientes: ");
            ListarPacientesByCodeAndName();
            Console.WriteLine("Informe o código do paciente que deseja excluir: ");
            Int32.TryParse(Console.ReadLine(), out codigopaciente1);
            Console.WriteLine("Confirme novamente o codigo do paciente: ");
            Int32.TryParse(Console.ReadLine(), out codigopaciente2);

            paciente = Program.Mock.ListPacientes.Find(p => p.CodigoPaciente == codigopaciente1 && p.CodigoPaciente == codigopaciente2);

            if(codigopaciente1 == codigopaciente2) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("Paciente Exluido com sucesso                          -----");
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

            ExcluirPaciente(paciente);


                        
        }


        #endregion
    }
}
