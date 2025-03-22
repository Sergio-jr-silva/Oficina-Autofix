using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AutoFix.Clientes
{
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
        }

        private string connectionString = "Server=localhost;Database=autofix;Uid=root;Pwd=3477;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Método para cadastrar o cliente no banco de dados
        public void Cadastro(string nome, string cpf, string telefone, string email, string cep,
                             string rua, string bairro, string numero, string veiculo, string ano, string placa)
        {
            try
            {
                string query = @"INSERT INTO clientes (nome, cpf, telefone, email, cep, rua, bairro, numero, veiculo, ano, placa) 
                                 VALUES (@nome, @cpf, @telefone, @email, @cep, @rua, @bairro, @numero, @veiculo, @ano, @placa)";

                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    MessageBox.Show("Conectado ao banco de dados!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@cep", cep);
                        cmd.Parameters.AddWithValue("@rua", rua);
                        cmd.Parameters.AddWithValue("@bairro", bairro);
                        cmd.Parameters.AddWithValue("@numero", numero);
                        cmd.Parameters.AddWithValue("@veiculo", veiculo);
                        cmd.Parameters.AddWithValue("@ano", ano);
                        cmd.Parameters.AddWithValue("@placa", placa);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi inserido. Verifique os dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento do botão cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
          
        }

        private void CadastroClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string cpf = txtCpf.Text.Trim();
            string telefone = txtTelefone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string cep = txtCep.Text.Trim();
            string rua = txtRua.Text.Trim();
            string bairro = txtBairro.Text.Trim();
            string numero = txtNumero.Text.Trim();
            string veiculo = txtVeiculo.Text.Trim();
            string ano = txtAno.Text.Trim();
            string placa = txtPlaca.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf) ||
                string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(placa))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cadastro(nome, cpf, telefone, email, cep, rua, bairro, numero, veiculo, ano, placa);
        }
    }
}
