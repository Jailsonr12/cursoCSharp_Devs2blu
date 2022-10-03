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
    public class CadrastoMedicoIngles : IMenuCadrasto {
        public CadrastoMedicoIngles() {

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
                Console.WriteLine($"Doctor: {medico.CodigoMedico}");
                Console.WriteLine($"Name: {medico.Nome}");
                Console.WriteLine($"ITIN: {medico.CGCCPF}");
                Console.WriteLine($"Specialty: {medico.Especialidade}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

            }
            Console.WriteLine("Type anything to exit");
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
            Console.WriteLine("----- 1 - Doctor List                                 -----");
            Console.WriteLine("----- 2 - Doctor Registration                         -----");
            Console.WriteLine("----- 3 - Change Doctor                               -----");
            Console.WriteLine("----- 4 - Delete Doctor                               -----");
            Console.WriteLine("----- 0 - EXIT                                        -----");
            Console.WriteLine("----- Enter the number of the option you want to see  -----");
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

            Console.WriteLine("Enter the Doctor's name: ");
            medico.Nome = Console.ReadLine();

            Console.WriteLine("Enter the Doctor's ITIN: ");
            medico.CGCCPF = Console.ReadLine();

            Console.WriteLine("Inform the Doctor's CRM: ");
            medico.CRM = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Inform the doctor's specialty: ");
            medico.Especialidade = Console.ReadLine();

            CadrastrarMedico(medico);
        }

        public void Alterar() {

            Console.Clear();
            Medico medico;
            int codigoMedico;

            Console.WriteLine("Tell the Doctor you want to change: ");
            ListarMedicosByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoMedico);

            medico = Program.Mock.ListMedico.Find(p => p.CodigoMedico == codigoMedico);

            string opcaoAlterar;
            bool alterar = true;

            do {
                Console.WriteLine($"Medico: {medico.Codigo}/{medico.CodigoMedico} | Nome: {medico.Nome} | ITIN: {medico.CGCCPF} | Specialty: {medico.Especialidade}");
                Console.WriteLine("Which field do you want to change?");
                Console.WriteLine("01 - Nome | 02 - ITIN | 03 - Specialty |04 - CRM | 00 - Sair");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar) {
                    case "01":
                        Console.WriteLine("Enter a new name: ");
                        medico.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Enter a new ITIN: ");
                        medico.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Enter a new specialty: ");
                        medico.Especialidade = Console.ReadLine();
                        break;
                    case "04":
                        Console.WriteLine("Report a new CRM: ");
                        medico.CRM = Int32.Parse( Console.ReadLine());
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

            AlterarMedico(medico);
        }

        public void Excluir() {

            Console.Clear();
            Medico medico;
            int codigoMedico1;
            int codigoMedico2;

            Console.WriteLine("| List of Doctors: ");
            ListarMedicosByCodeAndName();
            Console.WriteLine("Enter the Doctor code you want to delete: ");
            Int32.TryParse(Console.ReadLine(), out codigoMedico1);
            Console.WriteLine("Confirm the patient code again: ");
            Int32.TryParse(Console.ReadLine(), out codigoMedico2);

            medico = Program.Mock.ListMedico.Find(m => m.CodigoMedico == codigoMedico1 && m.CodigoMedico == codigoMedico2);

            if (codigoMedico1 == codigoMedico2) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("Doctors Deleted Successfully                         -----");
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


            ExcluirMedico(medico);

        }

        private void ExcluirMedico(Medico medico) {

            Program.Mock.ListMedico.Remove(medico);
        }


    }
}
