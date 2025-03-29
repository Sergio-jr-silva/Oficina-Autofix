using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutoFix.Clientes
{
    public partial class ConsultaClientes : Form
    {
        private List<Cliente> clientes;

        public ConsultaClientes()
        {
            InitializeComponent();
            CriarCabecalho();
            CarregarClientes();
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

        private void CarregarClientes()
        {
            clientes = new List<Cliente>
            {
                new Cliente { Id = 1, Nome = "João Silva", Email = "joao@email.com", Telefone = "9999-9999", Data = "11/12/2022" },
                new Cliente { Id = 2, Nome = "Maria Oliveira", Email = "maria@email.com", Telefone = "9888-8888", Data = "10/03/2021" },
                new Cliente { Id = 3, Nome = "Carlos Souza", Email = "carlos@email.com", Telefone = "9777-7777", Data = "12/02/2002" }
            };

            AtualizarLista(clientes);
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
