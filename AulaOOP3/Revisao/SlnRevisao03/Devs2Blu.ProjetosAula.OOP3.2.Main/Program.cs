using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3._2.Main {
    public class Program {
        public static Mocks Mock { get; set; }

        static void Main(string[] args) {

            Mock = new Mocks();
        }

        public static void ViewListaPaciente() {
            Console.Clear();

            foreach (Paciente paceinte in Mock.ListPaciente) {
                Console.WriteLine($"Paciente: {paceinte.CodigoPaciente}";
                Console.WriteLine($"Nome: {paceinte.nome}";
                Console.WriteLine($"CPF: {paceinte.CGCCPF}";
                Console.WriteLine($"Convenio: {paceinte.Covenio}";


            }
        }
    }
}
