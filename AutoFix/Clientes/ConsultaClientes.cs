using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AutoFix.Clientes
{
    public partial class ConsultaClientes : Form
    {
        private List<Cliente> clientes;

        public ConsultaClientes()
        {
            InitializeComponent();
            CriarCabecalho();
            CarregarClientesDoBanco();
        }

        private void CriarCabecalho()
        {
            Panel panelCabecalho = new Panel
            {
                Width = flowLayoutPanelClientes.Width - 100,
                Height = 30,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = System.Drawing.Color.LightGray
            };

            Label lblTituloNome = new Label
            {
                Text = "Nome",
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(10, 5)
            };

            Label lblTituloEmail = new Label
            {
                Text = "Email",
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(200, 5)
            };

            Label lblTituloTelefone = new Label
            {
                Text = "Telefone",
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(400, 5)
            };

            Label lblTituloDetalhes = new Label
            {
                Text = "Detalhes",
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(600, 5)
            };

            panelCabecalho.Controls.Add(lblTituloNome);
            panelCabecalho.Controls.Add(lblTituloEmail);
            panelCabecalho.Controls.Add(lblTituloTelefone);
            panelCabecalho.Controls.Add(lblTituloDetalhes);

            flowLayoutPanelClientes.Controls.Add(panelCabecalho);
        }

        private void CarregarClientesDoBanco()
        {
            clientes = new List<Cliente>();
            string connectionString = "server=localhost;database=autofix;uid=root;pwd=3477;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, nome, email, telefone, data_cadastro FROM clientes";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                clientes.Add(new Cliente
                                {
                                    Id = reader.GetInt32("id"),
                                    Nome = reader.GetString("nome"),
                                    Email = reader.GetString("email"),
                                    Telefone = reader.GetString("telefone"),
                                    Data = reader.GetDateTime("data_cadastro").ToString("dd/MM/yyyy")
                                });
                            }
                        }
                    }

                    AtualizarLista(clientes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AtualizarLista(List<Cliente> lista)
        {
            flowLayoutPanelClientes.Controls.Clear();
            CriarCabecalho();

            foreach (var cliente in lista)
            {
                Panel panelCliente = new Panel
                {
                    Width = flowLayoutPanelClientes.Width - 100,
                    Height = 40,
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label lblNome = new Label
                {
                    Text = cliente.Nome,
                    AutoSize = true,
                    Location = new System.Drawing.Point(10, 10)
                };

                Label lblEmail = new Label
                {
                    Text = cliente.Email,
                    AutoSize = true,
                    Location = new System.Drawing.Point(200, 10)
                };

                Label lblTel = new Label
                {
                    Text = cliente.Telefone,
                    AutoSize = true,
                    Location = new System.Drawing.Point(400, 10)
                };

                Button btnDetalhes = new Button
                {
                    Text = "Ver Detalhes",
                    Width = 120,
                    Height = 30,
                    Location = new System.Drawing.Point(600, 5)
                };

                btnDetalhes.Click += (sender, e) => AbrirDetalhes(cliente);

                panelCliente.Controls.Add(lblNome);
                panelCliente.Controls.Add(lblEmail);
                panelCliente.Controls.Add(lblTel);
                panelCliente.Controls.Add(btnDetalhes);

                flowLayoutPanelClientes.Controls.Add(panelCliente);
            }
        }

        private void AbrirDetalhes(Cliente cliente)
        {
            DetalhesCliente detalhesCliente = new DetalhesCliente(cliente);
            detalhesCliente.ShowDialog();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtPesquisa.Text.ToLower();
            var clientesFiltrados = clientes
                .Where(c => c.Nome.ToLower().Contains(filtro))
                .ToList();

            AtualizarLista(clientesFiltrados);
        }
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Data { get; set; }
    }
}
