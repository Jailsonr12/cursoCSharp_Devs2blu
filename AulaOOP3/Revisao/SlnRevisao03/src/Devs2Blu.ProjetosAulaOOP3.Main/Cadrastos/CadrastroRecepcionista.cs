using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAulaOOP3.Main.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos {
    public class CadrastroRecepcionista {

        public CadrastroRecepcionista() {

        }
        public void MenuCadastroRecepcionista() {
            Int32 opcao;
            do {
                Console.WriteLine("----- Cadastro de Paciente -----");
                Console.WriteLine("----- 1- Lista de Paciente -----");
                Console.WriteLine("----- 2- Cadastro de Paciente -----");
                Console.WriteLine("----- 3- Alterar  Paciente -----");
                Console.WriteLine("----- 0- SAIR -----");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao) {
                    case (int)MenuEnums.LISTAR:
                        ListarRecepcionista();
                        break;

                    default:
                        break;


                }

            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }

        public void ListarRecepcionista() {

            Console.Clear();

            foreach (Recepcionista recepcionista in Program.Mock.ListRecepcionista) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine($"Recepcionista: {recepcionista.CodigoRecepcionista}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"CPF: {recepcionista.CGCCPF}");
                Console.WriteLine($"Convenio: {recepcionista.Setor}");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

            }

        }
        public void CadrastrarPaciente() {

        }
        public void AlterarPaciente() {

        }
        public void ExcluirPaciente() {

        }
    }
}
