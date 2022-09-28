using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos.Interface;
using Devs2Blu.ProjetosAulaOOP3.Main.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos {
    public class CadrastroRecepcionista : IMenuCadrasto {

        public CadrastroRecepcionista() {

        }
        public Int32 MenuCadastro() {
            Int32 opcao;

            Console.WriteLine("----- Cadastro de Recepcionista -----");
            Console.WriteLine("----- 1- Lista de Recepcionista -----");
            Console.WriteLine("----- 2- Cadastro de Recepcionista -----");
            Console.WriteLine("----- 3- Alterar  Recepcionista -----");
            Console.WriteLine("----- 0- SAIR -----");
            Int32.TryParse(Console.ReadLine(), out opcao);

            return opcao;
        }

        public void Lista() {

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



        public void Cadrastrar() {
            throw new NotImplementedException();
        }

        public void Alterar() {
            throw new NotImplementedException();
        }

        public void Excluir() {
            throw new NotImplementedException();
        }
    }
}
