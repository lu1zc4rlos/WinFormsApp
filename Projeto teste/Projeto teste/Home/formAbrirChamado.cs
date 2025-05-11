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
using Projeto_teste.Home;
using Regras_de_negócio;

namespace ProjetoTeste.Home
{
    public partial class formAbrirChamado : Form
    {
        private Usuario _usuario;
        public formAbrirChamado(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }
      
        private void formAbrirChamado_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validações
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Por favor, insira uma descrição do problema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Coletar dados
            string prioridade = comboBox2.SelectedItem.ToString();
            string tipoChamado = comboBoxTipo.SelectedItem.ToString();
            string descricao = txtDescricao.Text.Trim();
            string status = "Aberto"; 
            DateTime dataCriacao = DateTime.Now;
            int usuarioId = _usuario.Id; 

            try
            {
                TicketClienteDAL _ticketClienteDAL = new TicketClienteDAL();

                _ticketClienteDAL.CriarTicket(new Ticket
                {
                    Titulo = tipoChamado,
                    Prioridade = prioridade,
                    Status = status,
                    Descricao = descricao,
                    DataCriacao = dataCriacao,
                    UsuarioId = usuarioId

                });

                MessageBox.Show("Chamado enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                using (formChamados _formChamados = new formChamados(_usuario))
                {
                    _formChamados.ShowDialog();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar chamado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    

