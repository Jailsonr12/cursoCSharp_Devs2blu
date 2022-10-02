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
    public class CadrastroPacienteIngles : IMenuCadrasto {
        public CadrastroPacienteIngles() {

        }


        private void ListarPacientes() {

            Console.Clear();

            foreach (Paciente paceinte in Program.Mock.ListPacientes) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine($"Patient: {paceinte.CodigoPaciente}");
                Console.WriteLine($"Name: {paceinte.Nome}");
                Console.WriteLine($"ITIN: {paceinte.CGCCPF}");
                Console.WriteLine($"Health insurance: {paceinte.Convenio}");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

            }
            Console.WriteLine("Enter 0 to exit");
            Console.ReadLine();

        }
        //
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
            Console.WriteLine("----- Patient Record                                  -----");
            Console.WriteLine("----- 1 - Patient List                                -----");
            Console.WriteLine("----- 2 - Patient Record                              -----");
            Console.WriteLine("----- 3 - Change Patient                              -----");
            Console.WriteLine("----- 4 - Delete Patient                              -----");
            Console.WriteLine("----- 0 - EXIT                                        -----");
            Console.WriteLine("----- Enter the number of the option you want to see  -----");
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

            Console.WriteLine("Enter the patient's name: ");
            paciente.Nome = Console.ReadLine();

            Console.WriteLine("Enter the patient's CPF: ");
            paciente.CGCCPF = Console.ReadLine();

            Console.WriteLine("Inform the patient's insurance: ");
            paciente.Convenio = Console.ReadLine();

            CadrastrarPaciente(paciente);
        }

        public void Alterar() {

            Console.Clear();
            Paciente paciente;
            int codigoPaciente;

            Console.WriteLine("Inform the patient that you want to change: ");
            ListarPacientesByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoPaciente);

            paciente = Program.Mock.ListPacientes.Find(p => p.CodigoPaciente == codigoPaciente);

            string opcaoAlterar;
            bool alterar = true;

            do {
                Console.WriteLine($"Patient: {paciente.Codigo}/{paciente.CodigoPaciente} | Name: {paciente.Nome} | ITIN: {paciente.CGCCPF} | Health insurance: {paciente.Convenio}");
                Console.WriteLine("Which field do you want to change?");
                Console.WriteLine("01 - Nome | 02 - ITIN | 03 - Health insurance | 00 - Sair");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar){
                    case "01":
                        Console.WriteLine("Enter a new name: ");
                        paciente.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Enter a new ITIN: ");
                        paciente.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Report a new agreement: ");
                        paciente.Convenio = Console.ReadLine();
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

            AlterarPaciente(paciente);
        }

        public void Excluir() {

            Console.Clear();
            Paciente paciente;
            int codigopaciente1;
            int codigopaciente2;

            Console.WriteLine("| List of Patients ");
            ListarPacientesByCodeAndName();
            Console.WriteLine("Enter the code of the patient you want to delete: ");
            Int32.TryParse(Console.ReadLine(), out codigopaciente1);
            Console.WriteLine("Confirm the patient code again ");
            Int32.TryParse(Console.ReadLine(), out codigopaciente2);

            paciente = Program.Mock.ListPacientes.Find(p => p.CodigoPaciente == codigopaciente1 && p.CodigoPaciente == codigopaciente2);

            if (codigopaciente1 == codigopaciente2) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("Patients Deleted Successfully                         -----");
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

            ExcluirPaciente(paciente);
                        
        }


        #endregion
    }
}
