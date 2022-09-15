using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dev2Blu.ProjetosAula3.ProjetoCondicionais {
    internal class Program {
        static void Main(string[] args) {

            Exemplo3();

        }

        static void Exemplo3() {

            int impar;

            Console.WriteLine("Imforme um numero");
            StringInfo imparSTR = Console.ReadLine();

            impar = Int32.Parse(imparSTR);
            
            if((impar - ((impar/2)*2)) == 0) {
                Console.WriteLine($"Esse numero {impar} impar");
            }
            else {
                 Console.WriteLine($"Esse numero {impar} par");
            }

            


        }


    }
}
