using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms {

    public partial class Form1 : Form {
        public MySqlConnection Conn { get; set; }

        public ConvenioRepository ConvenioRepository = new ConvenioRepository();
        public PacienteRepository PacienteRepository = new PacienteRepository();

        public Form1() {
            InitializeComponent();
        }

        #region Metodos

        private void PopulaComboConvenio() {
            var listConvenios = ConvenioRepository.FetchAll();

           cboConvenio.DataSource = new BindingSource(listConvenios, null);
           cboConvenio.DisplayMember = "nome";
            cboConvenio.ValueMember = "id";
        }
        private bool ValidaFormCadastro() {
            if (txtNome.Text.Equals("")) 
                return false;
            if (txtCGCCPF.Text.Equals(""))
                return false;
           /* if (cboConvenio.SelectedIndex == -1)
                return false;
            if (mskCEP.Text.Equals(""))
                return false;
            if (cboUF.SelectedIndex == -1)
                return false;
            if (txtCidade.Text.Equals(""))
                return false;
            if (txtBairro.Text.Equals(""))
                return false;
            if (txtNumero.Text.Equals(""))
                return false;
            if (txtTua.Text.Equals(""))
                return false;*/

            return true;

        }


        #endregion


        #region Evento
        private void Form1_Load(object sender, EventArgs e) {


            PopulaComboConvenio();

            //Conn = ConnectionMySQL.GetConnection();
            // if (Conn.State == ConnectionState.Open) {
            //     MessageBox.Show("Conexão efetuado com sucesso!", "Conexão ao MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     Conn.Close();
            // }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

            

                lbbCGCCPF.Text = "CPF";
                lbbCGCCPF.Visible = true;
            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {



                lbbCGCCPF.Text = "CNPJ";
                lbbCGCCPF.Visible = true;
            
        }

        private void btnsalve_Click(object sender, EventArgs e) {

            if (ValidaFormCadastro()) {
                Paciente paciente = new Paciente();
                paciente.Pessoa.Nome = txtNome.Text;
                paciente.Pessoa.CGCCPF = txtCGCCPF.Text;
                paciente.Convenio.Id = (int)cboConvenio.SelectedValue;
                var pacienteResult = PacienteRepository.Save(paciente);
                if (pacienteResult.Pessoa.id > 0) {

                    MessageBox.Show($"Pessoa {paciente.Pessoa.id} - {paciente.Pessoa.Nome} salva com sucesso!", "Adicionar Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }
        #endregion
    }
}
