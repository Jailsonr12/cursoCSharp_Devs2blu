using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetoAula.Aula6Loops {
    internal class Program {
        static void Main(string[] args) {

            Exemplo6();

        }

        static void ExemploProf1() {
            int controle = 1;
            while (controle > 0) {

                Console.WriteLine("Informe o codigo 0 para sair");
                Int32.TryParse(Console.ReadLine(), out controle);
            }
        }

        static void ExemploProf2() {
            int controle = 1;
            do {

                Console.WriteLine("Informe o codigo 0 para sair");
                Int32.TryParse(Console.ReadLine(), out controle);

            } while (controle > 0);

        }

        static void ExemploProf3() {
            int controle = 0;

            do {
                Console.WriteLine("Informe um dos códigos Abaixo");
                Console.WriteLine("1 - Exemplo1");
                Console.WriteLine("2 - Exemplo2");
                Int32.TryParse(Console.ReadLine(), out controle);

                switch (controle) {
                    case 1:
                        Exemplo1();
                        break;
                    case 2:
                        Exemplo2();
                        break;
                    default:
                        break;
                }

            } while (controle > 0);
        }

        static void Exemplo1() {
            int numero = 0;

            while (numero < 100) {
                if (!(numero % 2 == 0)) {
                    Console.WriteLine(numero + " Esse numero e impar");
                }
                numero++;
            }
        }

        static void Exemplo2() {
            int numero = 0;

            while (numero <= 100) {
                if (numero % 2 == 0) {
                    Console.WriteLine(numero + " Esse numero e par");
                }
                numero++;
            }
        }

        static void Exemplo3() {
            int numero = 0;
            int contador = 0;

            Console.WriteLine("Informe um numero");
            Int32.TryParse(Console.ReadLine(), out contador);

            while (numero <= contador) {
                if ((numero % 2 == 0)) {
                    Console.WriteLine(numero + " Esse numero e par");
                }

                numero++;
            }
            numero = 0;
            while (numero <= contador) {
                if ((numero % 2 != 0)) {
                    Console.WriteLine(numero + " Esse numero e impar");
                }

                numero++;
            }

        }

        static void Exemplo4() {
            int alunos;
            int meida;
            int notas;
            int soma= 0;
            int contador = 1;

            Console.WriteLine("Informe quantiade de aluno");
            Int32.TryParse(Console.ReadLine(), out alunos);
            while(alunos == 0){
                Console.WriteLine("Nao tem aluno nessa turma");
                Console.WriteLine("Infome a quantidade de aluno novamente");
                Int32.TryParse(Console.ReadLine(), out alunos);
            }
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            
            while (contador <= alunos) {
                Console.WriteLine("Informe a notas dos alunos");
                Int32.TryParse(Console.ReadLine(), out notas);
                soma += notas;
                contador++;

            }

            meida = soma / alunos;
            Console.WriteLine($"A media da turma é {meida}");
          

        }

        static void Exemplo5() {
            int coluna = 1;
            int viga = 0;

            while (coluna < 20) {
                Console.WriteLine($"|{coluna}|");
                coluna++;
            }
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            if (coluna == 20) {
                while (viga < coluna) {
                    viga++;
                    Console.Write($"|{viga}|");
                }
                Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            }
            Console.WriteLine("Fim de pograma");
        }

        static void Exemplo6() {
            int numero = 1000;

            while (numero < 1999) {
                if (numero % 11 == 5) {
                    Console.WriteLine(numero + "E dividido por 11");
                }
                numero++;
            }


        }




    }
}
