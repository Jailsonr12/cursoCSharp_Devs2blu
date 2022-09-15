using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroExercicios {
    internal class Program {
        static void Main(string[] args) {

            Exercicios1();



        }




        static void Exemplo3() {

            int impar;

            Console.WriteLine("Imforme um numero");
            string imparSTR = Console.ReadLine();

            impar = Int32.Parse(imparSTR);

            if (!(impar - impar / 2 * 2 == 0)) {
                Console.WriteLine($"Esse numero {impar} impar");
            }
            else {
                Console.WriteLine($"Esse numero {impar} par");
            }

        }

        static void Exemplo4() {

            Console.WriteLine("Menu");
            Console.WriteLine("01 - Arroz");
            Console.WriteLine("02 - Feijao");
            Console.WriteLine("03 - Farinha");
            Console.WriteLine("Escolha um produto");

            string menuSTR = Console.ReadLine();

            int menu = Int32.Parse(menuSTR);

            if (menu == 1) {
                Console.WriteLine("Voce Compro Arroz");
            }
            else if (menu == 2) {
                Console.WriteLine("Voce Compro feijao");

            }
            else if (menu == 3) {
                Console.WriteLine("Voce Compro feijao");

            }
        }

        static void Exemplo4Prof() {

            Console.WriteLine("Menu");
            Console.WriteLine("01 - Arroz");
            Console.WriteLine("02 - Feijao");
            Console.WriteLine("03 - Farinha");
            Console.WriteLine("Escolha um produto");

            string menuSTR = Console.ReadLine();

            int menu = Int32.Parse(menuSTR);

            if (menu.Equals("01")) {
                Console.WriteLine("Voce Compro Arroz");
            }
            else if (menu.Equals("02")) {
                Console.WriteLine("Voce Compro feijao");

            }
            else if (menu.Equals("03")) {
                Console.WriteLine("Voce Compro feijao");

            }
        }

        static void Exemplo5() {

            int anoNC, calculo;
            Console.WriteLine("Seu ano de nascimento");
            string anoNCSTR = Console.ReadLine();

            anoNC = Int32.Parse(anoNCSTR);

            calculo = DateTime.Now.Year - anoNC;

            if (calculo >= 16) {
                if (calculo >= 18) {
                    Console.WriteLine("Voce e obrigado a votar \n E deve se alistar ao Exercito Brasileiro");
                }
                else {
                    Console.WriteLine("Voce ja pode votar ");
                }
            }
            else {
                Console.WriteLine("Voce nao tem nem um direito legal como cidadao");

            }



        }

        static void Exemplo6() {

            string senhaSTR;
            const string SENHA_CORRETA = "1234";

            Console.Write("DIGITE A SENHA:");
            senhaSTR = Console.ReadLine();

            if (senhaSTR.Equals(SENHA_CORRETA)) {
                Console.WriteLine("ACESSO APROVADO");
            }
            else {
                Console.WriteLine("VOCE SERA PRESO IUIUIU");
            }

        }

        static void Exemplo7() {

            int quantidadeMaca;
            float calculo;

            Console.WriteLine("Informe a quantidade de maça que deseja compra");
            string macaSRT = Console.ReadLine();
            calculo = Int32.Parse(macaSRT);
            quantidadeMaca = Int32.Parse(macaSRT);

            if (quantidadeMaca >= 12) {
                Console.WriteLine("****************VALOR DA COMPRA****************");
                Console.WriteLine("OPA TEM PROMOÇÃO PARA COMPRA ACIMA DE 12 MAÇA");
                Console.WriteLine("VOCE PAGARA POR UNIDADE R$0.25");
                float preco = (float)(calculo * 0.25);
                Console.WriteLine($"\nQuantidade {quantidadeMaca} * R$0.25 \nPreço total= {preco}");

            }
            else {
                Console.WriteLine("****************VALOR DA COMPRA****************");
                Console.WriteLine("VOCE PAGARA POR UNIDADE R$0.30");
                float preco = (float)(calculo * 0.30);
                Console.WriteLine($"\nQuantidade {quantidadeMaca} * R$0.30 \nPreço total= {preco}");
            }



        }

        static void Exemplo8() {

            int n1 = 0, n2 = 0, n3 = 0;

            Random r1 = new Random();

            int v1 = r1.Next(1, 100);
            int v2 = r1.Next(1, 100);
            int v3 = r1.Next(1, 100);


            n1 = v1;
            n2 = v2;
            n3 = v3; ;
            while (n1 == n2 && n1 == n3 && n2 == n3) {
                n1 = v1;
                n2 = v2;
                n3 = v3;
            }

            Console.WriteLine("N1 = " + n1);
            Console.WriteLine("N2 = " + n2);
            Console.WriteLine("N3 = " + n3);



            if (n1 > n2 && n1 > n3) {
                if (n2 > n3) {
                    Console.WriteLine($"Maior para o menor n1 = {n1} n2 = {n2} n3 = {n3}");
                }
                else {
                    Console.WriteLine($"Maior para o menor n1 = {n1} n3 = {n3} n2 = {n2}");
                }

            }
            else if (n2 > n1 && n2 > n3) {
                if (n1 > n3) {
                    Console.WriteLine($"Maior para o menor n2 = {n2} n1 = {n1} n3 = {n3}");
                }
                else {
                    Console.WriteLine($"Maior para o menor n2 = {n2} n3 = {n3} n1 = {n1}");
                }

            }
            else if (n3 > n1 && n3 > n2) {
                if (n1 > n2) {
                    Console.WriteLine($"Maior para o menor n3 = {n3} n1 = {n1} n2 = {n2}");
                }
                else {
                    Console.WriteLine($"Maior para o menor n3 = {n3} n2 = {n2} n1 = {n1}");
                }

            }
        }

        static void Exercicios1() {

            int n1, n2;

            Random r1 = new Random();

            n1 = r1.Next(1, 100);
            n2 = r1.Next(1, 100);

            while (n1 == n2) {
                n1 = r1.Next(1, 100);
                n2 = r1.Next(1, 100);

            }

            if (n1 > n2) {
                Console.WriteLine($"O numero n1 = {n1} é maior que  numero n2 = {n2}");
            }
            else {
                Console.WriteLine($"O numero n2 = {n2} é maior que  numero n1 = {n1}");

            }

        }

        static void Exercicios2() {


        }

    }
}

