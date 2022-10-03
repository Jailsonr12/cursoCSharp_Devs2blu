using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAulaOOP3.Main.Utils {
    public class Mocks {
        public List<Paciente> ListPacientes { get; set; }
        public List<Medico> ListMedico { get; set; }
        public List<Recepcionista> ListRecepcionista { get; set; }
        public List<Fornecedor> ListFornecedor { get; set; }



        public Mocks() {
            ListPacientes = new List<Paciente>();
            ListMedico = new List<Medico>();
            ListRecepcionista = new List<Recepcionista>();
            ListFornecedor = new List<Fornecedor>();
            CargaMock();
        }

        public void CargaMock() {
            CargaPaceinte();
            CargaMedico();
            CargaRecepcionista();
            CargaFornecedor();

        }

        public void CargaPaceinte() {

            for (int i = 0; i < 10; i++) {

                Paciente paciente = new Paciente(i, $"Paciente {i}", $"{i}23{i}56{i}891{i}", "Unimed");
                ListPacientes.Add(paciente);
            }
        }
        public void CargaMedico() {

            Random rd = new Random();
            String[] especialidades = { "Clinico Geral", "Neurologista", "Ginecologista", "Pediatra" };

            for (int i = 0; i < 10; i++) {

                Medico medico = new Medico(i, $"Medico {i + 1}", $"{i}23{i}56{i}891{i}", rd.Next(100, 999), especialidades[rd.Next(0, especialidades.Length)]) ;
                ListMedico.Add(medico);
            }

        }
        
        public void CargaRecepcionista() {

            Random rd = new Random();
            String[] setor = { "Recepção", "Sala", "Saida", "Igreja" };

            for (int i = 0; i < 10; i++) {

                Recepcionista recepcionista = new Recepcionista(i, $"Recepcionista {i}", $"{i}23{i}56{i}891{i}", setor[rd.Next(0, 4)]);
                ListRecepcionista.Add(recepcionista);
            }
        }
        public void CargaFornecedor() {

            Random rd = new Random();
            String[] tipofornecedor = { "Medicamento", "Comida", "Sabonete", "Drogas", "Caixa" };

            for (int i = 0; i < 10; i++) {

                Fornecedor fornecedor = new Fornecedor(i, $"Fornecedor {i}", $"{i}23{i}56{i}891{i}", tipofornecedor[rd.Next(0, 5)]);
                ListFornecedor.Add(fornecedor);
            }
        }


    }

}
