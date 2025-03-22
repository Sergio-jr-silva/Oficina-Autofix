using AutoFix.Clientes;

namespace AutoFix
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (var CadastrarClientes = new CadastroClientes()) { 
                    CadastrarClientes.ShowDialog();
            }
        }
    }
}
