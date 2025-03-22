namespace AutoFix.Clientes
{
    partial class CadastroClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroClientes));
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtCpf = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            Telefone = new Label();
            Email = new Label();
            txtEmail = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCep = new TextBox();
            txtRua = new TextBox();
            txtBairro = new TextBox();
            txtNumero = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtVeiculo = new TextBox();
            txtAno = new TextBox();
            txtPlaca = new TextBox();
            textBox9 = new TextBox();
            label10 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.ForeColor = Color.DarkSlateGray;
            txtNome.Location = new Point(109, 23);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(402, 28);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(549, 26);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 2;
            label2.Text = "Cpf:";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(601, 23);
            txtCpf.Mask = "999-999-999-99";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(181, 28);
            txtCpf.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(141, 71);
            txtTelefone.Mask = "(999) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(195, 28);
            txtTelefone.TabIndex = 5;
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Location = new Point(40, 74);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(98, 21);
            Telefone.TabIndex = 6;
            Telefone.Text = "Telefone: ";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(358, 77);
            Email.Name = "Email";
            Email.Size = new Size(71, 21);
            Email.TabIndex = 7;
            Email.Text = "E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(425, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 28);
            txtEmail.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 141);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 9;
            label3.Text = "Cep: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 141);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 10;
            label4.Text = "Rua: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(751, 141);
            label5.Name = "label5";
            label5.Size = new Size(31, 21);
            label5.TabIndex = 11;
            label5.Text = "Nº";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(530, 141);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 12;
            label6.Text = "Bairro: ";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(91, 138);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(153, 28);
            txtCep.TabIndex = 13;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(312, 138);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(212, 28);
            txtRua.TabIndex = 14;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(601, 138);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(125, 28);
            txtBairro.TabIndex = 15;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(788, 138);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(97, 28);
            txtNumero.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 210);
            label7.Name = "label7";
            label7.Size = new Size(82, 21);
            label7.TabIndex = 17;
            label7.Text = "Veículo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(493, 210);
            label8.Name = "label8";
            label8.Size = new Size(51, 21);
            label8.TabIndex = 18;
            label8.Text = "Ano:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(711, 210);
            label9.Name = "label9";
            label9.Size = new Size(71, 21);
            label9.TabIndex = 19;
            label9.Text = "Placa: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(678, 74);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 28);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.Visible = false;
            // 
            // txtVeiculo
            // 
            txtVeiculo.Location = new Point(119, 207);
            txtVeiculo.Name = "txtVeiculo";
            txtVeiculo.Size = new Size(349, 28);
            txtVeiculo.TabIndex = 21;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(544, 207);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(125, 28);
            txtAno.TabIndex = 22;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(777, 207);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(125, 28);
            txtPlaca.TabIndex = 23;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(78, 310);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(648, 63);
            textBox9.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(78, 276);
            label10.Name = "label10";
            label10.Size = new Size(225, 21);
            label10.TabIndex = 25;
            label10.Text = "Complemento (opcional)";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(296, 410);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(311, 44);
            btnCadastrar.TabIndex = 26;
            btnCadastrar.Text = "Cadastrar Cliente";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // CadastroClientes
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 490);
            Controls.Add(btnCadastrar);
            Controls.Add(label10);
            Controls.Add(textBox9);
            Controls.Add(txtPlaca);
            Controls.Add(txtAno);
            Controls.Add(txtVeiculo);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtNumero);
            Controls.Add(txtBairro);
            Controls.Add(txtRua);
            Controls.Add(txtCep);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(Email);
            Controls.Add(Telefone);
            Controls.Add(txtTelefone);
            Controls.Add(txtCpf);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "CadastroClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro De Clientes";
            Load += CadastroClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private MaskedTextBox txtCpf;
        private MaskedTextBox txtTelefone;
        private Label Telefone;
        private Label Email;
        private MaskedTextBox txtEmail;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCep;
        private TextBox txtRua;
        private TextBox txtBairro;
        private TextBox txtNumero;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private TextBox txtVeiculo;
        private TextBox txtAno;
        private TextBox txtPlaca;
        private TextBox textBox9;
        private Label label10;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnCadastrar;
    }
}