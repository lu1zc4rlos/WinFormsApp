using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Access;
using Entidades;
using Regras_de_negócio;

namespace ProjetoTeste.Home
{
    public partial class formRespostaTecnico : Form
    {
        private int _idTicket;
        private TicketClienteDAL _ticketClienteDAL = new TicketClienteDAL();
        public formRespostaTecnico(int idTicket)
        {
            InitializeComponent();
            _idTicket = idTicket;
        }
        private void formRespostaTecnico_Load(object sender, EventArgs e)
        {
            CarregarDetalhesTicket();
        }
        private void CarregarDetalhesTicket()
        {
            try
            {
                Ticket ticket = _ticketClienteDAL.ObterTicketPorId(_idTicket);

                if (ticket != null)
                {
                    label3.Text = ticket.Descricao;
                    label4.Text = ticket.Resposta;
                }
                else
                {
                    MessageBox.Show("Chamado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar detalhes do chamado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelDescricao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
