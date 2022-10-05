using Devs2Blu.ProjetosAula.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev2Blu.ProjetosAula.AulaOOP1Int {
    public partial class Form1 : Form {

        public List<Recepcionista> RecepcionistasList { get; set; }
        public List<Diretor> DiretorsList { get; set; }


        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            this.BackColor = Color.Red;
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void anos_Click(object sender, EventArgs e) {

        }
    }
}
