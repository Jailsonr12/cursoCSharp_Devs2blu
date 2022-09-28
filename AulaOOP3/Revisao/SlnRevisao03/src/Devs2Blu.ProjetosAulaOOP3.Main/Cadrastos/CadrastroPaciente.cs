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


        public void Lista() {
            ListarPacientes();
        }

        public void Cadrastrar() {

            Paciente paciente = new Paciente();
            CadrastrarPaciente(paciente);
        }


        public void Alterar() {
            Paciente paciente = new Paciente();
            AlterarPaciente(paciente);
        }

        public void Excluir() {
            Paciente paciente = new Paciente();
            ExcluirPaciente(paciente);
        }


        #region FACEDE
        public Int32 MenuCadastro() {
            Int32 opcao;

            Console.WriteLine("----- Cadastro de Paciente -----");
            Console.WriteLine("----- 1- Lista de Paciente -----");
            Console.WriteLine("----- 2- Cadastro de Paciente -----");
            Console.WriteLine("----- 3- Alterar  Paciente -----");
            Console.WriteLine("----- 0- SAIR -----");
            Int32.TryParse(Console.ReadLine(), out opcao);



            return opcao;
        }
        private void ListarPacientes() {

            Console.Clear();

            foreach (Paciente paceinte in Program.Mock.ListPacientes) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine($"Paciente: {paceinte.CodigoPaciente}");
                Console.WriteLine($"Nome: {paceinte.Nome}");
                Console.WriteLine($"CPF: {paceinte.CGCCPF}");
                Console.WriteLine($"Convenio: {paceinte.Convenio}");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

            }

        }
        private void CadrastrarPaciente(Paciente novoPaciente) {

            Program.Mock.ListPacientes.Add(novoPaciente);

        }
        private void AlterarPaciente(Paciente pessoa) {

        }
        private void ExcluirPaciente(Paciente paciente) {
            Program.Mock.ListPacientes.Find(o => o.Codigo == paciente.Codigo);
        }



        #endregion
    }
}
