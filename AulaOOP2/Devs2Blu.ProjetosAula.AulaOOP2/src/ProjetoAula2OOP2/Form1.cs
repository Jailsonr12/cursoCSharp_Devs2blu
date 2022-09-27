using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAula2OOP2 {
    public partial class txtname : Form {
        public Contato Contat { get; set; }



        

        public txtname() {
            InitializeComponent();
            
        }
        public string Nome { get; set; }

        public string Celular { get; set; }

        public string Email { get; set; }

        public string CEP { get; set; }

        public string Rua { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        

        private void txtBoxName_TextChanged(object sender, EventArgs e) {
            Nome = txtBoxName.Text;
        }



        private void button1_Click(object sender, EventArgs e) {
            if (!ValidarForm()) {
                txtConsole.Text = "preencha todas as caixinhas";
                return ;
            }

            txtConsole.Text += "Meu nome é " + Nome;
            txtConsole.Text += "\r\n Telefome " + Celular;
            txtConsole.Text += "\r\n Email de contato é " + Email;
            txtConsole.Text += "\r\n Cep: " + CEP;
            txtConsole.Text += " Rua: " + Rua;
            txtConsole.Text += " Rua: " + Rua;
            txtConsole.Text += " Bairo: " + Bairro;
            txtConsole.Text += " Cidade " + Bairro;
            txtConsole.Text += " Estado: " + Bairro;
        }

        private void txtBoxCel_TextChanged(object sender, EventArgs e) {
            txtBoxCel.Text += Celular;
        }

        private void txtConsole_TextChanged(object sender, EventArgs e) {
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e) {
            Email = txtEmail.Text;
        }

        private void txtBoxCEP_TextChanged(object sender, EventArgs e) {
            CEP = txtBoxCEP.Text;
        }

        private void txtBoxRua_TextChanged(object sender, EventArgs e) {
            Rua = txtBoxRua.Text;
        }

        private void txtBoxBairo_TextChanged(object sender, EventArgs e) {
            Bairro = txtBoxBairo.Text;
        }

        private void txtBoxCidade_TextChanged(object sender, EventArgs e) {
            Cidade = txtBoxCidade.Text;
            
        }

        private void txtBoxEstado_TextChanged(object sender, EventArgs e) {
            Estado = txtBoxEstado.Text;
        }

        private void txtname_Load(object sender, EventArgs e) {
            if (!ValidarForm()) {
                txtConsole.Text = "preencha todas as caixinhas";
                return ;
            }
        }
        private void button2_Click(object sender, EventArgs e) {
            LimparForm();
        }

        public  void LimparForm() {
            txtBoxCel.Clear();
            txtConsole.Clear();
            txtEmail.Clear();
            txtBoxCEP.Clear();
            txtBoxRua.Clear();
            txtBoxBairo.Clear();
            txtBoxCidade.Clear();
            txtBoxEstado.Clear();
            txtBoxName.Clear();


        }

        public bool ValidarForm() {
            if (txtBoxName.Text.Equals("")) return false;
            if (txtBoxEstado.Text.Equals("")) return false;
            if (txtBoxCidade.Text.Equals("")) return false;
            if (txtBoxBairo.Text.Equals("")) return false;
            if (txtBoxRua.Text.Equals("")) return false;
            if (txtBoxCEP.Text.Equals("")) return false;
            if (txtEmail.Text.Equals("")) return false;
            if (txtConsole.Text.Equals("")) return false;
            if (txtBoxCel.Text.Equals("")) return false;

            return  true;
        }

    }
}
