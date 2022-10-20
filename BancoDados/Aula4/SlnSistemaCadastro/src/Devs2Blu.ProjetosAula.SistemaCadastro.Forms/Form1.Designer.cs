namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.gpFormCadastro = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpEnderecoCadastro = new System.Windows.Forms.GroupBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.ComboBox();
            this.txtBairro = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.ComboBox();
            this.txtTua = new System.Windows.Forms.ComboBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbbCGCCPF = new System.Windows.Forms.Label();
            this.gpTipoPessoa = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cboConvenio = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridePacientes = new System.Windows.Forms.DataGridView();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControle = new System.Windows.Forms.Panel();
            this.btnsalve = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.txtCGCCPF = new System.Windows.Forms.MaskedTextBox();
            this.gpFormCadastro.SuspendLayout();
            this.gpEnderecoCadastro.SuspendLayout();
            this.gpTipoPessoa.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridePacientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelControle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Convenio";
            // 
            // gpFormCadastro
            // 
            this.gpFormCadastro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gpFormCadastro.Controls.Add(this.txtCGCCPF);
            this.gpFormCadastro.Controls.Add(this.btnLimpar);
            this.gpFormCadastro.Controls.Add(this.gpEnderecoCadastro);
            this.gpFormCadastro.Controls.Add(this.txtNome);
            this.gpFormCadastro.Controls.Add(this.label4);
            this.gpFormCadastro.Controls.Add(this.lbbCGCCPF);
            this.gpFormCadastro.Controls.Add(this.gpTipoPessoa);
            this.gpFormCadastro.Controls.Add(this.cboConvenio);
            this.gpFormCadastro.Controls.Add(this.label1);
            this.gpFormCadastro.Location = new System.Drawing.Point(12, 47);
            this.gpFormCadastro.Name = "gpFormCadastro";
            this.gpFormCadastro.Size = new System.Drawing.Size(493, 279);
            this.gpFormCadastro.TabIndex = 2;
            this.gpFormCadastro.TabStop = false;
            this.gpFormCadastro.Text = "Formulario de Cadastro";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.Location = new System.Drawing.Point(24, 241);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(74, 25);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // gpEnderecoCadastro
            // 
            this.gpEnderecoCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpEnderecoCadastro.Controls.Add(this.cboUF);
            this.gpEnderecoCadastro.Controls.Add(this.mskCEP);
            this.gpEnderecoCadastro.Controls.Add(this.txtCidade);
            this.gpEnderecoCadastro.Controls.Add(this.txtBairro);
            this.gpEnderecoCadastro.Controls.Add(this.txtNumero);
            this.gpEnderecoCadastro.Controls.Add(this.txtTua);
            this.gpEnderecoCadastro.Controls.Add(this.lblUF);
            this.gpEnderecoCadastro.Controls.Add(this.lblCidade);
            this.gpEnderecoCadastro.Controls.Add(this.lblBairro);
            this.gpEnderecoCadastro.Controls.Add(this.lblNumero);
            this.gpEnderecoCadastro.Controls.Add(this.lblRua);
            this.gpEnderecoCadastro.Controls.Add(this.lblCEP);
            this.gpEnderecoCadastro.Location = new System.Drawing.Point(24, 109);
            this.gpEnderecoCadastro.Name = "gpEnderecoCadastro";
            this.gpEnderecoCadastro.Size = new System.Drawing.Size(452, 126);
            this.gpEnderecoCadastro.TabIndex = 13;
            this.gpEnderecoCadastro.TabStop = false;
            this.gpEnderecoCadastro.Text = "Endereço/Contato";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(55, 30);
            this.mskCEP.Mask = "000000-00";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(87, 20);
            this.mskCEP.TabIndex = 14;
            // 
            // txtCidade
            // 
            this.txtCidade.FormattingEnabled = true;
            this.txtCidade.Location = new System.Drawing.Point(55, 56);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(197, 21);
            this.txtCidade.TabIndex = 23;
            // 
            // txtBairro
            // 
            this.txtBairro.FormattingEnabled = true;
            this.txtBairro.Location = new System.Drawing.Point(55, 83);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(370, 21);
            this.txtBairro.TabIndex = 22;
            // 
            // txtNumero
            // 
            this.txtNumero.FormattingEnabled = true;
            this.txtNumero.Location = new System.Drawing.Point(359, 29);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(66, 21);
            this.txtNumero.TabIndex = 21;
            // 
            // txtTua
            // 
            this.txtTua.FormattingEnabled = true;
            this.txtTua.Location = new System.Drawing.Point(306, 56);
            this.txtTua.Name = "txtTua";
            this.txtTua.Size = new System.Drawing.Size(119, 21);
            this.txtTua.TabIndex = 20;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(152, 32);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 19;
            this.lblUF.Text = "UF:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(6, 64);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 18;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(12, 91);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 17;
            this.lblBairro.Text = "Bairro";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(310, 32);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 16;
            this.lblNumero.Text = "Numero:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(270, 59);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 13);
            this.lblRua.TabIndex = 15;
            this.lblRua.Text = "Rua:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(9, 37);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 14;
            this.lblCEP.Text = "CEP:";
            // 
            // txtNome
            // 
            this.txtNome.FormattingEnabled = true;
            this.txtNome.Location = new System.Drawing.Point(62, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(195, 21);
            this.txtNome.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nome";
            // 
            // lbbCGCCPF
            // 
            this.lbbCGCCPF.AutoSize = true;
            this.lbbCGCCPF.Location = new System.Drawing.Point(21, 85);
            this.lbbCGCCPF.Name = "lbbCGCCPF";
            this.lbbCGCCPF.Size = new System.Drawing.Size(27, 13);
            this.lbbCGCCPF.TabIndex = 8;
            this.lbbCGCCPF.Text = "CPF";
            this.lbbCGCCPF.UseWaitCursor = true;
            // 
            // gpTipoPessoa
            // 
            this.gpTipoPessoa.Controls.Add(this.radioButton1);
            this.gpTipoPessoa.Controls.Add(this.radioButton2);
            this.gpTipoPessoa.Location = new System.Drawing.Point(272, 36);
            this.gpTipoPessoa.Name = "gpTipoPessoa";
            this.gpTipoPessoa.Size = new System.Drawing.Size(204, 40);
            this.gpTipoPessoa.TabIndex = 6;
            this.gpTipoPessoa.TabStop = false;
            this.gpTipoPessoa.Text = "Tipo Pessoa";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fisica";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(128, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Juridica";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cboConvenio
            // 
            this.cboConvenio.FormattingEnabled = true;
            this.cboConvenio.Location = new System.Drawing.Point(79, 28);
            this.cboConvenio.Name = "cboConvenio";
            this.cboConvenio.Size = new System.Drawing.Size(178, 21);
            this.cboConvenio.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridePacientes);
            this.panel1.Location = new System.Drawing.Point(525, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 278);
            this.panel1.TabIndex = 3;
            // 
            // gridePacientes
            // 
            this.gridePacientes.AllowUserToAddRows = false;
            this.gridePacientes.AllowUserToOrderColumns = true;
            this.gridePacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridePacientes.Location = new System.Drawing.Point(3, 3);
            this.gridePacientes.Name = "gridePacientes";
            this.gridePacientes.ReadOnly = true;
            this.gridePacientes.Size = new System.Drawing.Size(257, 272);
            this.gridePacientes.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panelControle
            // 
            this.panelControle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelControle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelControle.BackgroundImage")));
            this.panelControle.Controls.Add(this.btnInfo);
            this.panelControle.Controls.Add(this.btnExcluir);
            this.panelControle.Controls.Add(this.btnsalve);
            this.panelControle.Location = new System.Drawing.Point(12, 332);
            this.panelControle.Name = "panelControle";
            this.panelControle.Size = new System.Drawing.Size(773, 81);
            this.panelControle.TabIndex = 5;
            // 
            // btnsalve
            // 
            this.btnsalve.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsalve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalve.BackgroundImage")));
            this.btnsalve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalve.Location = new System.Drawing.Point(24, 5);
            this.btnsalve.Name = "btnsalve";
            this.btnsalve.Size = new System.Drawing.Size(74, 72);
            this.btnsalve.TabIndex = 0;
            this.btnsalve.UseVisualStyleBackColor = false;
            this.btnsalve.Click += new System.EventHandler(this.btnsalve_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(121, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(79, 74);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.Location = new System.Drawing.Point(689, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(80, 73);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // cboUF
            // 
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(182, 29);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(118, 21);
            this.cboUF.TabIndex = 15;
            // 
            // txtCGCCPF
            // 
            this.txtCGCCPF.Location = new System.Drawing.Point(62, 82);
            this.txtCGCCPF.Mask = "000.000.000-00";
            this.txtCGCCPF.Name = "txtCGCCPF";
            this.txtCGCCPF.Size = new System.Drawing.Size(195, 20);
            this.txtCGCCPF.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 426);
            this.Controls.Add(this.panelControle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpFormCadastro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "+Devs@BLu_Sistema de Cadastro Hospital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpFormCadastro.ResumeLayout(false);
            this.gpFormCadastro.PerformLayout();
            this.gpEnderecoCadastro.ResumeLayout(false);
            this.gpEnderecoCadastro.PerformLayout();
            this.gpTipoPessoa.ResumeLayout(false);
            this.gpTipoPessoa.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridePacientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelControle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpFormCadastro;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cboConvenio;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox gpTipoPessoa;
        private System.Windows.Forms.Label lbbCGCCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtNome;
        private System.Windows.Forms.GroupBox gpEnderecoCadastro;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.ComboBox txtCidade;
        private System.Windows.Forms.ComboBox txtBairro;
        private System.Windows.Forms.ComboBox txtNumero;
        private System.Windows.Forms.ComboBox txtTua;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridePacientes;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panelControle;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnsalve;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.MaskedTextBox txtCGCCPF;
    }
}

