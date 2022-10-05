using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model {
    public class Endereco {

        public int Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public String CEP { get; set; }
        public String Rua { get; set; }
        public int Numero { get; set; }
        public String Bairo { get; set; }
        public String Cidade { get; set; }
        public String UF { get; set; }

        public Endereco() { }

        public Endereco(int id, Pessoa pessoa, string cEP, string rua, int numero, string bairo, string cidade, string uF) {
            Id = id;
            Pessoa = pessoa;
            CEP = cEP;
            Rua = rua;
            Numero = numero;
            Bairo = bairo;
            Cidade = cidade;
            UF = uF;
        }


    }
}
