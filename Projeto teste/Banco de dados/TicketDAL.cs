using System.Collections.Generic;
using System;
using Datai_Accesso;
using Entidades;
using Npgsql;

namespace Data_Access
{
    public class TicketDAL
    {
        public bool AtualizarStatus(int id, string novoStatus)
        {
            string query = "UPDATE ticket SET status = @NovoStatus WHERE id_ticket = @IdTicket;";

            using (var conexao = ConexaoDAL.Abrir())
            using (var comando = new NpgsqlCommand(query, conexao))
            {
                comando.Parameters.AddWithValue("@NovoStatus", novoStatus);
                comando.Parameters.AddWithValue("@IdTicket", id);

                int linhasAfetadas = comando.ExecuteNonQuery();
                return linhasAfetadas > 0;
            }
        }
        public List<Ticket> ObterTicketsDoBanco(string statusFiltro = null)
        {
            var tickets = new List<Ticket>();

            string query = "SELECT id_ticket, nome_chamado, prioridade, status, data_criacao, usuario_id FROM \"ticket\"";
            if (!string.IsNullOrEmpty(statusFiltro))
            {
                query += " WHERE status = @StatusFiltro";
            }

            using (var conexao = ConexaoDAL.Abrir())
            using (var comando = new NpgsqlCommand(query, conexao))
            {

                if (!string.IsNullOrEmpty(statusFiltro))
                {
                    comando.Parameters.AddWithValue("@StatusFiltro", statusFiltro);
                }

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ticket = new Ticket
                        {
                            ID = "#HDN" + reader.GetInt32(0).ToString("D3"),
                            Titulo = reader.GetString(1),
                            Cliente = "Usuário " + reader.GetInt32(5).ToString(),
                            Prioridade = reader.GetString(2),
                            Tempo = CalcularTempo(reader.GetDateTime(4)),
                            Status = reader.GetString(3)
                        };
                        tickets.Add(ticket);
                    }
                }
            }

            return tickets;
        }
        private string CalcularTempo(DateTime dataCriacao)
        {
            var tempo = DateTime.Now - dataCriacao;

            if (tempo.TotalMinutes < 60)
            {
                return $"{(int)tempo.TotalMinutes} minuto(s)";
            }
            else if (tempo.TotalHours < 24)
            {
                return $"{(int)tempo.TotalHours} hora(s)";
            }
            else if (tempo.TotalDays < 7)
            {
                return $"{(int)tempo.TotalDays} dia(s)";
            }
            else if (tempo.TotalDays < 30)
            {
                return $"{(int)(tempo.TotalDays / 7)} semana(s)";
            }
            else if (tempo.TotalDays < 365)
            {
                return $"{(int)(tempo.TotalDays / 30)} mês(es)";
            }
            else
            {
                return $"{(int)(tempo.TotalDays / 365)} ano(s)";
            }
        }
        public Ticket BuscarTicketPorId(int id)
        {
            Ticket ticket = null;
            string query = "SELECT id_ticket, nome_chamado, prioridade, status, data_criacao, usuario_id, descricao FROM ticket WHERE id_ticket = @id";

            using (var conexao = ConexaoDAL.Abrir())
            using (var comando = new NpgsqlCommand(query, conexao))
            {
                comando.Parameters.AddWithValue("@id", id);

                using (var reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ticket = new Ticket
                        {
                            ID = "#HDN" + reader.GetInt32(0).ToString("D3"),
                            Titulo = reader.GetString(1),
                            Prioridade = reader.GetString(2),
                            Status = reader.GetString(3),
                            Tempo = CalcularTempo(reader.GetDateTime(4)),
                            UsuarioId = reader.GetInt32(5),
                            Descricao = reader.GetString(6)
                        };
                    }
                }
                return ticket;
            }
        }
        public void AdicionarResposta(int idTicket, string resposta)
        {
            string query = "UPDATE ticket SET resposta = @resposta, status = 'Concluído' WHERE id_ticket = @id";

            using (var conexao = ConexaoDAL.Abrir())
            using (var comando = new NpgsqlCommand(query, conexao))
            {
                comando.Parameters.AddWithValue("@resposta", resposta);
                comando.Parameters.AddWithValue("@id", idTicket);

                comando.ExecuteNonQuery();
            }
        }
    }
}



    


