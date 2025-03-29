namespace AutoFix.Clientes
{
    partial class ConsultaClientes
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
            txtPesquisa = new TextBox();
            label1 = new Label();
            button1 = new Button();
            flowLayoutPanelClientes = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisa.Location = new Point(131, 42);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(459, 34);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 45);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 2;
            label1.Text = "Nome: ";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(616, 42);
            button1.Name = "button1";
            button1.Size = new Size(187, 34);
            button1.TabIndex = 3;
            button1.Text = "Buscar Cliente";
            button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelClientes
            // 
            flowLayoutPanelClientes.Location = new Point(101, 118);
            flowLayoutPanelClientes.Name = "flowLayoutPanelClientes";
            flowLayoutPanelClientes.Size = new Size(859, 467);
            flowLayoutPanelClientes.TabIndex = 4;
            // 
            // ConsultaClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 597);
            Controls.Add(flowLayoutPanelClientes);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtPesquisa);
            Name = "ConsultaClientes";
            Text = "ConsultaClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPesquisa;
        private Label label1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanelClientes;
    }
}