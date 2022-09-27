using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos;
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

            Int32 opcao;
            Mock = new Mocks();
            do {
                Console.WriteLine("----- Sistema De Gerencimento de Clínicas -----");
                Console.WriteLine("----- 10- Cadastro de Paciente -----");
                Console.WriteLine("----- 20- Cadastro de Medico -----");
                Console.WriteLine("----- 30- Cadastro de Recepcionista -----");
                Console.WriteLine("----- 40- Cadastro de Fornecedor -----");
                Console.WriteLine("----- 50- Agenda -----");
                Console.WriteLine("----- 60- Protuario -----");
                Console.WriteLine("----- 70- Financeiro -----");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("----- 0- Sair  -----");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao) {
                    case (int)MenuEnums.CAD_PAC:
                        CadrastroPaciente moduloCadrastoPaciente = new CadrastroPaciente();
                        moduloCadrastoPaciente.MenuCadastroPaciente();
                        break;
                    case (int)MenuEnums.CAD_MED:
                        CadrastoMedico moduloCadrastoMedico = new CadrastoMedico();
                        moduloCadrastoMedico.MenuCadastroMedico();
                        break;
                    case (int)MenuEnums.CAD_REC:
                        CadrastroRecepcionista moduloCadrastoRecepcionista = new CadrastroRecepcionista();
                        moduloCadrastoRecepcionista.MenuCadastroRecepcionista();
                        break;
                    case (int)MenuEnums.CAD_FOR:
                        CadrastoFornecedor moduloCadrastoFornecedor = new CadrastoFornecedor() ;
                        moduloCadrastoFornecedor.MenuCadrastoFornecedoro();
                        break;
                    default:
                        break;


                }

            } while (!opcao.Equals((int)MenuEnums.SAIR));

        }

        

    }
}
