using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos;
using Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos.Interface;
using Devs2Blu.ProjetosAulaOOP3.Main.Utils;
using Devs2Blu.ProjetosAulaOOP3.Main.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAulaOOP3.Main {
    public class Program {
        public static Mocks Mock { get; set; }

        static void Main(string[] args) {

            Int32 opcao = 0, opcaoMenuCadrasto = 0;

            Mock = new Mocks();
            IMenuCadrasto menuCadrasto = new CadrastroPaciente();
            do {


                if (opcaoMenuCadrasto.Equals((int)MenuEnums.SAIR)) {
                    Console.WriteLine("----- Sistema De Gerencimento de Clínicas -----");
                    Console.WriteLine("----- 10 - Cadastro de Paciente -----");
                    Console.WriteLine("----- 20 - Cadastro de Medico -----");
                    Console.WriteLine("----- 30 - Cadastro de Recepcionista -----");
                    Console.WriteLine("----- 40 - Cadastro de Fornecedor -----");
                    Console.WriteLine("----- 50 - Agenda -----");
                    Console.WriteLine("----- 60 - Protuario -----");
                    Console.WriteLine("----- 70 - Financeiro -----");
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine("----- 0 - Sair  -----");
                    Int32.TryParse(Console.ReadLine(), out opcao);

                }
                switch (opcao) {
                    case (int)MenuEnums.CAD_PAC:
                        menuCadrasto = new CadrastroPaciente();
                        opcaoMenuCadrasto = menuCadrasto.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_MED:
                        menuCadrasto = new CadrastoMedico();
                        opcaoMenuCadrasto = menuCadrasto.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_REC:
                        menuCadrasto = new CadrastroRecepcionista();
                        opcaoMenuCadrasto = menuCadrasto.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_FOR:
                        menuCadrasto = new CadrastoFornecedor();
                         opcaoMenuCadrasto = menuCadrasto.MenuCadastro();

                        break;
                    default:
                        menuCadrasto = new CadrastroPadrao();
                        opcaoMenuCadrasto = 0;
                        break;


                }


                switch (opcaoMenuCadrasto) {
                    case (int)MenuEnums.LISTAR:
                        menuCadrasto.Lista();
                        break;
                    case (int)MenuEnums.CADASTROR:
                        menuCadrasto.Cadrastrar();
                        break;
                    case (int)MenuEnums.ALTERAR:
                        menuCadrasto.Alterar();
                        break;
                    case (int)MenuEnums.EXCLUIR:
                        menuCadrasto.Excluir();
                        break;
                    default:
                        opcaoMenuCadrasto = 0;
                        break;


                }

            } while (!opcao.Equals((int)MenuEnums.SAIR));

        }



    }
}
