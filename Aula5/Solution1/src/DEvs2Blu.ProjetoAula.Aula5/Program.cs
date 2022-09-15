using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEvs2Blu.ProjetoAula.Aula5 {
    class Program {
        static void Main(string[] args) {
            Exercicios5();



        }

        static void Aula() {
            const string A21 = "A21";
            const string A22 = "A22";
            const string A23 = "A23";
            const string A24 = "A24";
            const string A35 = "A35";
            const string Z16 = "Z16";

            /*
             *  - "A23" : Materiais
                - "A35": Produtos Perecíveis
                - "Z16": Produtos Químicos
             */
            string codigo;

            Console.WriteLine("Escolha um código para ver a descrição");
            Console.WriteLine("- A21");
            Console.WriteLine("- A22");
            Console.WriteLine("- A23");
            Console.WriteLine("- A24");
            Console.WriteLine("- A35");
            Console.WriteLine("- Z16");

            codigo = Console.ReadLine();

            switch (codigo.ToUpper()) {
                case A21:
                case A22:
                case A23:
                case A24:
                    Console.WriteLine("A23: Materiais.");
                    break;
                case A35:
                    Console.WriteLine("A35: Produtos Perecíveis.");
                    break;
                case Z16:
                    Console.WriteLine("Z16: Produtos Químicos.");
                    break;

                default:
                    Console.WriteLine("Produto Não Cadastrado.");
                    break;

            }

        }

        static void Exercicios1() {

            string fruta;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("   Informe qual Fruta voce quer");
            Console.WriteLine("-------------------------------------");
            Console.Write("--- Maça ---");
            Console.Write(" Kiwi ---");
            Console.WriteLine(" Melancia ---");
            fruta = Console.ReadLine();

            switch (fruta.ToUpper()) {
                case "MAÇA":
                    Console.WriteLine("Não vendemos esta fruta aqui");
                    break;
                case "KIWI":
                    Console.WriteLine("Estamos com escasses de kiwi");
                    break;
                case "MELANCIA":
                    Console.WriteLine("Aqui está, sao 3 reais o quilo");
                    break;

                default:
                    Console.WriteLine("Nao temos essa frura");
                    break;
            }


        }

        static void Exercicios2() {

            string modeloCarro;

            Console.WriteLine("=-=-=-=-=-==-=-=-=-==-=-=-=-=");
            Console.WriteLine("Qual carro vc deseja");
            Console.WriteLine("=-=-=-=-=-==-=-=-=-==-=-=-=-=");
            Console.WriteLine("MODELOS:");
            Console.WriteLine("hatch");
            Console.WriteLine("sedans");
            Console.WriteLine("motocicletas");
            Console.WriteLine("caminhonetes");
            Console.WriteLine("=-=-=-=-=-==-=-=-=-==-=-=-=-=");
            Console.Write("Escolha seu modelo:");
            modeloCarro = Console.ReadLine();

            switch (modeloCarro.ToUpper()) {
                case "SEDANS":
                case "MOTOCICLETAS":
                case "CAMINHONETES":
                    Console.WriteLine("Tem certeza que não prefere este modelo?");
                    break;
                case "HATCH":
                    Console.WriteLine("Compra efetuada com sucesso");
                    break;
                default:
                    Console.WriteLine("Nao trabalhamos com esse modelo");
                    break;
            }
        }

        static void Exercicios3() {

            string calculadora;

            Console.WriteLine("Qual operação matematica deseja fazer?");
            Console.WriteLine("-- SOMA");
            Console.WriteLine("-- SUBTRAÇÃO");
            Console.WriteLine("-- MULTIPLICAÇÃO");
            Console.WriteLine("-- DIVISÃO");
            Console.WriteLine("Qual deseja fazer:");
            calculadora = Console.ReadLine();

            switch (calculadora.ToUpper()) {
                case "SOMA":
                    Console.WriteLine(" Sera realizado uma operação de SOMA (+)");
                    break;
                case "SUBTRAÇÃO":
                    Console.WriteLine(" Sera realizado uma operação de SUBTRAÇÃO (-)");
                    break;
                case "MULTIPLICAÇÃ":
                    Console.WriteLine(" Sera realizado uma operação de MULTIPLICAÇÃ ( * ou X )");
                    break;
                case "DIVISÃO":
                    Console.WriteLine(" Sera realizado uma operação de DIVISÃO (/)");
                    break;
                default:
                    break;
            }


        }

        static void Exercicios4() {
            string compra;
            Console.WriteLine("Escolha um tipo de produto");
            Console.WriteLine("-=- Produto");
            Console.WriteLine("-=- Frutas");
            Console.WriteLine("-=- Bebidas");

            compra = Console.ReadLine();

            switch (compra.ToUpper()) {
                case "PRODUTO":
                    Console.WriteLine("Produtos Não-perecíveis: arroz, feijão, café");
                    break;
                case "FRUTAS":
                    Console.WriteLine("Frutas: manga, banana, maçã");
                    break;
                case "BEBIDAS":
                    Console.WriteLine("Bebidas: leite, sucos, refrigerantes");
                    break;
                default:
                    break;
            }




        }

        static void Exercicios5() {

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Bem vindo ao jogo 21");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            int numeroCompautador;
            string numeroHumano;
            int pontoPC = 0;
            int pontoHm = 0;



            Random c1 = new Random();
            Console.WriteLine("Escolha seu numero Humano");
            numeroHumano = Console.ReadLine();
            numeroCompautador = c1.Next(1, 20);
            string numeroCompautadorSTR = numeroCompautador.ToString();

            switch (numeroCompautadorSTR) {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine("As maquinas fizeram 1 pontos");
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    pontoPC = 1;
                    break;
                case "8":
                case "9":
                case "10":
                case "11":
                case "12":
                case "13":
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine("As maquinas fizeram 5 pontos");
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    pontoPC = 5;
                    break;
                case "15":
                case "16":
                case "17":
                case "18":
                case "19":
                case "20":
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine("As maquinas fizeram 6 pontos");
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    pontoPC = 6;
                    break;
                case "7":
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine("As maquinas fizeram 10 pontos");
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    pontoPC = 10;
                    break;
                case "14":
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine("As maquinas fizeram 20 pontos");
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    pontoPC = 20;
                    break;
                case "21":
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine("As maquinas fizeram 30 pontos");
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    pontoPC = 30;
                    break;
                default:
                    break;
            }
            switch (numeroHumano) {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine("Humanos fizeram 1 pontos");
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    pontoHm = 1;
                    break;
                case "8":
                case "9":
                case "10":
                case "11":
                case "12":
                case "13":
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine("Humanos fizeram 5 pontos");
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    pontoHm = 5;
                    break;
                case "15":
                case "16":
                case "17":
                case "18":
                case "19":
                case "20":
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine("Humanos fizeram 6 pontos");
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    pontoHm = 6;
                    break;
                case "7":
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine("Humanos fizeram 10 pontos");
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    pontoHm = 10;
                    break;
                case "14":
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine("Humanos fizeram 20 pontos");
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    pontoHm = 20;
                    break;
                case "21":
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine("Humanos fizeram 30 pontos");
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    pontoHm = 30;
                    break;
                default:
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine("Desistiu seu fracasado X_X");
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                    break;
            }

            if (pontoHm > pontoPC) {
                Console.WriteLine("\n\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("Humanos ganhamos");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            }
            else {
                Console.WriteLine("\n\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("Perdemos Galera");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            }


        }




    }
}
