using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAulaOOP3.Main.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAulaOOP3.Main.Utils;

namespace Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos {
    public class CadrastoMedico {
        public CadrastoMedico() {

        }
        public void MenuCadastroMedico() {
            Int32 opcao;
            do {
                Console.WriteLine("----- Cadastro de Medico -----");
                Console.WriteLine("----- 1- Lista de Medico -----");
                Console.WriteLine("----- 2- Cadastro de Medico -----");
                Console.WriteLine("----- 3- Alterar  Medico -----");
                Console.WriteLine("----- 0- SAIR -----");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao) {
                    case (int)MenuEnums.LISTAR:
                        ListarMedico();
                        break;
                    default:
                        break;


                }

            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }

        public void ListarMedico() {

            Console.Clear();

            foreach (Medico medico in Program.Mock.ListMedico) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine($"Medico: {medico.CodigoMedico}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"CPF: {medico.CGCCPF}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

            }

        }
        public void CadrastrarMedico() {

        }
        public void AlterarMedico() {

        }
        public void ExcluirMedico() {

        }
    }
}
