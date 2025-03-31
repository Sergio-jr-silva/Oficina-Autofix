namespace AutoFix.Clientes
{
    partial class DetalhesCliente
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            lblNome = new Label();
            lblDataCadastro = new Label();
            lblVeiculo = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 25);
            label1.Name = "label1";
            label1.Size = new Size(293, 32);
            label1.TabIndex = 0;
            label1.Text = "Informações Do Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user1;
            pictureBox1.Location = new Point(32, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(187, 89);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 2;
            label2.Text = "Nome: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(187, 136);
            label3.Name = "label3";
            label3.Size = new Size(130, 17);
            label3.TabIndex = 3;
            label3.Text = "Data do Cadastro: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(187, 180);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 4;
            label4.Text = "Veículo: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(187, 225);
            label5.Name = "label5";
            label5.Size = new Size(117, 17);
            label5.TabIndex = 5;
            label5.Text = "Ultima Revisão: ";
            // 
            // button1
            // 
            button1.Location = new Point(22, 279);
            button1.Name = "button1";
            button1.Size = new Size(169, 29);
            button1.TabIndex = 6;
            button1.Text = "Alterar Cadastro";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(245, 87);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(0, 20);
            lblNome.TabIndex = 7;
            // 
            // lblDataCadastro
            // 
            lblDataCadastro.AutoSize = true;
            lblDataCadastro.Location = new Point(323, 136);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(0, 20);
            lblDataCadastro.TabIndex = 8;
            // 
            // lblVeiculo
            // 
            lblVeiculo.AutoSize = true;
            lblVeiculo.Location = new Point(254, 180);
            lblVeiculo.Name = "lblVeiculo";
            lblVeiculo.Size = new Size(0, 20);
            lblVeiculo.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(310, 223);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 10;
            label6.Text = "Não Efeutada";
            // 
            // DetalhesCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 388);
            Controls.Add(label6);
            Controls.Add(lblVeiculo);
            Controls.Add(lblDataCadastro);
            Controls.Add(lblNome);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "DetalhesCliente";
            Text = "DetalhesCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label lblNome;
        private Label lblDataCadastro;
        private Label lblVeiculo;
        private Label label6;
    }
}