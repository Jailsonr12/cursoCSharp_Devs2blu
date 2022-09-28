using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos.Interface;
using Devs2Blu.ProjetosAulaOOP3.Main.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos {
    public class CadrastoFornecedor : IMenuCadrasto{

        public Int32 MenuCadrasto() {
            Int32 opcao;
            
                Console.WriteLine("----- Cadastro de Fornecedor -----");
                Console.WriteLine("----- 1- Lista de Fornecedor -----");
                Console.WriteLine("----- 2- Cadastro de Fornecedor -----");
                Console.WriteLine("----- 3- Alterar  Fornecedor -----");
                Console.WriteLine("----- 0- SAIR -----");
                Int32.TryParse(Console.ReadLine(), out opcao);

                return opcao;
        }

        public void Lista() {

            Console.Clear();

            foreach (Fornecedor fornecedor in Program.Mock.ListFornecedore) {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine($"Medico: {fornecedor.CodigoFornecedor}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"CPF: {fornecedor.CGCCPF}");
                Console.WriteLine($"Mercadoria: {fornecedor.TipoFornecedor}");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

            }

        }

        public CadrastoFornecedor() {
        }

        public void Alterar() {
            throw new NotImplementedException();
        }

        public void Cadrastrar() {
            throw new NotImplementedException();
        }

        public void Excluir() {
            throw new NotImplementedException();
        }

       
              

      





    }
}
