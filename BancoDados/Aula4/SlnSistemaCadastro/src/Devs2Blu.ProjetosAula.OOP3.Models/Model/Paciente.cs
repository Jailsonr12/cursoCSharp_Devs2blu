using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model {
    public class Paciente  {

        public Int32 ID { get; set; }

        public Pessoa Pessoa { get; set; }
        public Convenio Convenio { get; set; }
        public Int32 NrProntuario { get; set; }
        public FlStatus Status { get; set; }

        public String PacienteRisco { get; set; }
        public Int32 FLObito { get; set; }



        public Paciente() {
            Pessoa = new Pessoa();
            Convenio = new Convenio();
            Status = FlStatus.A;
            FLObito = 0;

        }

        public Paciente(int iD, Pessoa pessoa, Convenio convenio, int nrProntuario, FlStatus status, string pacienteRisco, int fLObito) {
            ID = iD;
            Pessoa = pessoa;
            Convenio = convenio;
            NrProntuario = nrProntuario;
            Status = status;
            PacienteRisco = pacienteRisco;
            FLObito = fLObito;
        }

        public Paciente( Pessoa pessoa, Convenio convenio, int nrProntuario,  string pacienteRisco) {
            
            Pessoa = pessoa;
            Convenio = convenio;
            NrProntuario = nrProntuario;
            Status = FlStatus.A;
            PacienteRisco = pacienteRisco;
            FLObito = 0;


        }
    }

    }
