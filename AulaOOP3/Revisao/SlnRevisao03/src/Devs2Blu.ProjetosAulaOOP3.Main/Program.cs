using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos;
using Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos.CadrastoIngles;
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
            Int32 idioma = 1;

            

            Int32 opcao = 0, opcaoMenuCadrasto = 0;

            Mock = new Mocks();
            Ingles Trocaridioma = new Ingles();


            IMenuCadrasto menuCadrasto;
            do {

                if (idioma == 1) {

                    if (opcaoMenuCadrasto.Equals((int)MenuEnums.SAIR)) {

                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("----- Sistema De Gerencimento de Clínicas             -----");
                        Console.WriteLine("----- 10 - Cadastro de Paciente                       -----");
                        Console.WriteLine("----- 20 - Cadastro de Medico                         -----");
                        Console.WriteLine("----- 30 - Cadastro de Recepcionista                  -----");
                        Console.WriteLine("----- 40 - Cadastro de Fornecedor                     -----");
                        Console.WriteLine("----- 50 - Agenda                                     -----");
                        Console.WriteLine("----- 60 - Protuario                                  -----");
                        Console.WriteLine("----- 70 - Financeiro                                 -----");
                        Console.WriteLine("----- 80 - Idioma                                     -----");
                        Console.WriteLine("----- 0  - Sair                                       -----");
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                        Int32.TryParse(Console.ReadLine(), out opcao);

                    }
                    Console.Clear();

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
                        case (int)MenuEnums.IDIOMA:
                            
                            if (Trocaridioma.AlterarIdioma(idioma) == 1) {
                                idioma = 1;
                            }
                            else {
                                idioma = 2;
                            }

                            menuCadrasto = new CadrastroPadrao();
                            opcaoMenuCadrasto = (int)MenuEnums.SAIR;
                            break;
                        default:
                            menuCadrasto = new CadrastroPadrao();
                            opcaoMenuCadrasto = (int)MenuEnums.SAIR;
                            break;
                    }
                    Console.Clear();

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

                }
                else if (idioma == 2) {
                    if (opcaoMenuCadrasto.Equals((int)MenuEnums.SAIR)) {
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("----- Clinic Management System                        -----");
                        Console.WriteLine("----- 10 - Patient Record                             -----");
                        Console.WriteLine("----- 20 - Doctor Registration                        -----");
                        Console.WriteLine("----- 30 - Receptionist Registration                  -----");
                        Console.WriteLine("----- 40 - Supplier Registration                      -----");
                        Console.WriteLine("----- 50 - Schedule                                   -----");
                        Console.WriteLine("----- 60 - File                                       -----");
                        Console.WriteLine("----- 70 - Financial                                  -----");
                        Console.WriteLine("----- 80 - Language                                   -----");
                        Console.WriteLine("----- 0  - Exit                                       -----");
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                        Int32.TryParse(Console.ReadLine(), out opcao);

                    }
                    Console.Clear();
                    switch (opcao) {
                        case (int)MenuEnums.CAD_PAC:
                            menuCadrasto = new CadrastroPacienteIngles();
                            opcaoMenuCadrasto = menuCadrasto.MenuCadastro();
                            break;
                        case (int)MenuEnums.CAD_MED:
                            menuCadrasto = new CadrastoMedicoIngles();
                            opcaoMenuCadrasto = menuCadrasto.MenuCadastro();
                            break;
                        case (int)MenuEnums.CAD_REC:
                            menuCadrasto = new CadrastroRecepcionistaIngles();
                            opcaoMenuCadrasto = menuCadrasto.MenuCadastro();
                            break;
                        case (int)MenuEnums.CAD_FOR:
                            menuCadrasto = new CadrastoFornecedorIngles();
                            opcaoMenuCadrasto = menuCadrasto.MenuCadastro();
                            break;
                        case (int)MenuEnums.IDIOMA:
                            Console.Clear();
                            if (Trocaridioma.AlterarIdioma(idioma) == 1) {
                                idioma = 1;
                            }
                            else {
                                idioma = 2;
                            }

                            menuCadrasto = new CadrastroPadrao();
                            opcaoMenuCadrasto = (int)MenuEnums.SAIR;
                            break; ;
                        default:
                            menuCadrasto = new CadrastroPadrao();
                            opcaoMenuCadrasto = (int)MenuEnums.SAIR;
                            break;
                    }
                    Console.Clear();

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



                }

            } while (!opcao.Equals((int)MenuEnums.SAIR));

        }



    }
}
