using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data;
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

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {


            PopulaComboConvenio();

            //Conn = ConnectionMySQL.GetConnection();

            // if (Conn.State == ConnectionState.Open) {
            //     MessageBox.Show("Conexão efetuado com sucesso!", "Conexão ao MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     Conn.Close();
            // }

        }


        private void PopulaComboConvenio() {
            var listConvenios = ConvenioRepository.FetchAll();

            while (listConvenios.Read()) {
                cboConvenio.Items.Add(listConvenios.GetString("nome"));
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

            if (radioButton1.Checked) {

                lbbCGCCPF.Text = "CPF";
                lbbCGCCPF.Visible = true;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {


            if (radioButton2.Checked) {

                lbbCGCCPF.Text = "CNPJ";
                lbbCGCCPF.Visible = true;
            }
        }
    }
}
