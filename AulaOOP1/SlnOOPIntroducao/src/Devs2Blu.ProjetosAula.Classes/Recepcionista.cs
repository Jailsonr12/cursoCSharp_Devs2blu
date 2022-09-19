using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Classes {
    public class Recepcionista : Pessoa {


        public int CodigoConsulta { get; set; }

        public Recepcionista() {

            Novo = "Novo";
            SobreNome = "RECEPCIONISTA";
            NumeroCracha = 99999999;
        
        }
        public Recepcionista(string nome, string sobreNome) {
            this.Nome = nome;
            SobreNome = sobreNome;
        }
        public Recepcionista(int numer, string sobreNome) {
            this.Nome = nome;
            SobreNome = sobreNome;
        }

        public int NumeroCracha { get; set; }
        public string AgendaConsulta() {
            return $"Consulta Agendada!";
        }
    }

}


