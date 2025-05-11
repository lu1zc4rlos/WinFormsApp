using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTeste.Home_Técnico
{
    public partial class HomeTecnico : Form
    {
        public HomeTecnico()
        {
            InitializeComponent();
            ArredondarBotao(btnTicketsTotais, 20);
            ArredondarBotao(btnTicketsAbertos, 20);
            ArredondarBotao(btnEmAtendimento, 20);
            ArredondarBotao(btnTicketsFechados, 20);
        }
        private void ArredondarBotao(Button botao, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(botao.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(botao.Width - raio, botao.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, botao.Height - raio, raio, raio, 90, 90);
            path.CloseFigure();

            botao.Region = new Region(path);
        }
        private List<(string Codigo, string Titulo, string Cliente, string Prioridade, string TempoAberto, string Status)> ObterTicketsDoBanco()
        {
            return new List<(string, string, string, string, string, string)> {
                ("#HDN201", "Sistema fora do ar", "João Silva", "Alta", "5 minutos", "Aberto"),
                ("#HDN202", "Erro ao acessar o sistema", "Maria Oliveira", "Baixa", "10 minutos", "Em atendimento"),
                ("#HDN203", "Relatório não gera", "Carlos Pereira", "Média", "15 minutos", "Fechado"),
               ("#HDN204", "Sistema precisa de manutencao", "Augusto Santos", "Média", "2 minutos", "Aberto"),
            };
        }
        public Panel CriarTicketCard(string codigo, string nome, string cliente, string prioridade, string tempo, string status)
        {
            Panel card = new Panel();
            card.Width = 700;
            card.Height = 80;
            card.BackColor = Color.FromArgb(245, 245, 255); 
            card.Padding = new Padding(10);
            card.Margin = new Padding(5);
            card.BorderStyle = BorderStyle.FixedSingle;

            TableLayoutPanel table = new TableLayoutPanel();
            table.Dock = DockStyle.Fill;
            table.ColumnCount = 6;
            table.RowCount = 2;
            table.Padding = new Padding(0);
            table.Margin = new Padding(0);

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7)); // Código
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9)); // Nome chamado
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6)); // Cliente
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6)); // Prioridade
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6)); // Há
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12)); // Status

            table.Controls.Add(NovaLabel("Código", true), 0, 0);
            table.Controls.Add(NovaLabel("Nome chamado", true), 1, 0);
            table.Controls.Add(NovaLabel("Cliente", true), 2, 0);
            table.Controls.Add(NovaLabel("Prioridade", true), 3, 0);
            table.Controls.Add(NovaLabel("Há", true), 4, 0);
            table.Controls.Add(NovaLabel("Status", true), 5, 0);

            table.Controls.Add(NovaLabel(codigo), 0, 1);
            table.Controls.Add(NovaLabel(nome, false, Color.DeepPink), 1, 1);
            table.Controls.Add(NovaLabel(cliente), 2, 1);
            table.Controls.Add(NovaLabel(prioridade), 3, 1);
            table.Controls.Add(NovaLabel(tempo), 4, 1);
            table.Controls.Add(NovaLabel(status), 5, 1);

            card.Controls.Add(table);
            return card;
        }
        private Label NovaLabel(string texto, bool negrito = false, Color? cor = null)
        {
            return new Label
            {
                Text = texto,
                Font = new Font("Segoe UI", negrito ? 9F : 8.5F, negrito ? FontStyle.Bold : FontStyle.Regular),
                ForeColor = cor ?? Color.Black,
                AutoSize = true,
                Anchor = AnchorStyles.Left,
                Margin = new Padding(3, 0, 3, 0) 
            };
        }
        private void btnTicketsTotais_Click(object sender, EventArgs e)
        {
            flowLayoutPanelCards.Controls.Clear(); 

            var listaTickets = ObterTicketsDoBanco(); 

            foreach (var ticket in listaTickets)
            {
                var card = CriarTicketCard(ticket.Codigo, ticket.Titulo, ticket.Cliente, ticket.Prioridade, ticket.TempoAberto, ticket.Status);
                flowLayoutPanelCards.Controls.Add(card);
            }
        }
        private void HomeTecnico_Load(object sender, EventArgs e){}
        private void btnTicketsAbertos_Click(object sender, EventArgs e){}
        private void btnEmAtendimento_Click(object sender, EventArgs e){}
        private void lblDashboardPrincipal_Click(object sender, EventArgs e){}
        private void flowLayoutPanelCards_Paint(object sender, PaintEventArgs e){}
    }
}
