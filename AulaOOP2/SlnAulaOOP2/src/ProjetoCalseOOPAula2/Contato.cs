using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalseOOPAula2
{
    public class Contato
    {
        public String Nome { get; set; }

        public String Celular { get; set; }

        public String Email { get; set; }

        public String CEP { get; set; }

        public String Rua { get; set; }

        public String Bairro { get; set; }

        public String Cidade { get; set; }

        public String Estado { get; set; }


        public Contato() {
            Nome = "";
            Celular = "";
            Email = "";
            CEP = "";
            Rua = "";
            Bairro = "";
            Cidade = "";
            Estado = "";
        }





    }
}
