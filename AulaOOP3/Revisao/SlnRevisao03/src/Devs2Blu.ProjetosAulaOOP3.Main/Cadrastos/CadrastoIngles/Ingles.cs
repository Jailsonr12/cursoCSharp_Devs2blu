using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAulaOOP3.Main.Cadrastos.CadrastoIngles {
    public class Ingles {

        public Ingles() {
        
        }


      

        public int AlterarIdioma(int idioma) {
            Console.Clear();

            if (idioma == 1) {
                Console.Clear();
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("----- Idioma                                          -----");
                Console.WriteLine("----- 1 - Portugues                                   -----");
                Console.WriteLine("----- 2 - Ingles                                      -----");
                Console.WriteLine("----- Escolha uma opção de idioma                     ----");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Int32.TryParse(Console.ReadLine(), out idioma);

            }
            else if (idioma == 2) {
                Console.Clear();
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("----- Linguage                                        -----");
                Console.WriteLine("----- 1 - Portugues                                   -----");
                Console.WriteLine("----- 2 - Ingles                                      -----");
                Console.WriteLine("----- Choose a language option                        -----");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Int32.TryParse(Console.ReadLine(), out idioma);
            }
            return idioma;
        }
    


    }
}
