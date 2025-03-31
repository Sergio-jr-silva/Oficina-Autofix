using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AutoFix.Clientes
{
    public partial class DetalhesCliente : Form
    {
        private Cliente? clienteSelecionado;

        public DetalhesCliente(Cliente? clienteSelecionado)
        {
            InitializeComponent();
            this.clienteSelecionado = clienteSelecionado;
            CarregarDadosCliente();
        }

        private void CarregarDadosCliente()
        {
            if (clienteSelecionado == null)
            {
                MessageBox.Show("Nenhum cliente selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            string connectionString = "server=localhost;database=autofix;uid=root;pwd=3477;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nome, veiculo, data_cadastro FROM clientes WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", clienteSelecionado.Id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblNome.Text = reader["nome"].ToString();
                                lblVeiculo.Text = reader["veiculo"].ToString();
                                lblDataCadastro.Text = Convert.ToDateTime(reader["data_cadastro"]).ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                MessageBox.Show("Cliente não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
