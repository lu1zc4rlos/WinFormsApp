using Datai_Accesso;
using Entidades;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Data_Access
{
    public class TicketClienteDAL
    {
        public List<Ticket> ObterTicketsDoBancoPorUsuario(int idUsuario, string statusFiltro = null)
        {
            var tickets = new List<Ticket>();

            // Base da consulta
            string query = @"SELECT 
                        t.id_ticket, 
                        t.nome_chamado, 
                        t.prioridade, 
                        t.status, 
                        t.data_criacao, 
                        u.nome 
                     FROM 
                        ""ticket"" t
                     INNER JOIN 
                        ""dados_pessoais"" u ON t.usuario_id = u.idusuario
                     WHERE 
                        t.usuario_id = @IdUsuario";

            // Se tiver filtro de status, adiciona à consulta
            if (!string.IsNullOrEmpty(statusFiltro))
            {
                query += " AND t.status = @Status";
            }

            using (var conexao = ConexaoDAL.Abrir())
            using (var comando = new NpgsqlCommand(query, conexao))
            {
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

                if (!string.IsNullOrEmpty(statusFiltro))
                {
                    comando.Parameters.AddWithValue("@Status", statusFiltro);
                }

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ticket = new Ticket
                        {
                            ID = "#HDN" + reader.GetInt32(0).ToString("D3"),
                            Titulo = reader.GetString(1),
                            Prioridade = reader.GetString(2),
                            Status = reader.GetString(3),
                            Tempo = CalcularTempo(reader.GetDateTime(4)),
                            Cliente = reader.GetString(5)
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
        public void ExcluirTicket(int idTicket)
        {
            string query = "DELETE FROM tecnico WHERE ticket_id = @IdTicket";
            string query1 = "DELETE FROM \"ticket\" WHERE id_ticket = @IdTicket";

            using (var conexao = ConexaoDAL.Abrir())
            using (var comando = new NpgsqlCommand(query, conexao))
            {
                comando.Parameters.AddWithValue("@IdTicket", idTicket);
                comando.ExecuteNonQuery();
            }

            using (var conexao = ConexaoDAL.Abrir())
            using (var comando = new NpgsqlCommand(query1, conexao))
            {
                comando.Parameters.AddWithValue("@IdTicket", idTicket);
                comando.ExecuteNonQuery();
            }
        }
        public void CriarTicket(Ticket ticket)
        {
            string query = @"
                INSERT INTO ""ticket""
                (nome_chamado, prioridade, status, descricao, data_criacao, usuario_id)
                VALUES
                (@NomeChamado, @Prioridade, @Status, @Descricao, @DataCriacao, @UsuarioId)
            ";

            using (var conexao = ConexaoDAL.Abrir())
            using (var comando = new NpgsqlCommand(query, conexao))
            {
                comando.Parameters.AddWithValue("@NomeChamado", ticket.Titulo);
                comando.Parameters.AddWithValue("@Prioridade", ticket.Prioridade);
                comando.Parameters.AddWithValue("@Status", ticket.Status);
                comando.Parameters.AddWithValue("@Descricao", ticket.Descricao);
                comando.Parameters.AddWithValue("@DataCriacao", ticket.DataCriacao);
                comando.Parameters.AddWithValue("@UsuarioId", ticket.UsuarioId);

                comando.ExecuteNonQuery();
            }
        }
        public Ticket ObterTicketPorId(int idTicket)
        {
            Ticket ticket = null;

            string query = @"SELECT 
                        t.descricao, 
                        t.resposta
                     FROM 
                        ""ticket"" t
                     WHERE 
                        t.id_ticket = @IdTicket";

            using (var conexao = ConexaoDAL.Abrir())
            using (var comando = new Npgsql.NpgsqlCommand(query, conexao))
            {
                comando.Parameters.AddWithValue("@IdTicket", idTicket);

                using (var reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ticket = new Ticket
                        {
                            Descricao = reader.IsDBNull(0) ? "" : reader.GetString(0),
                            Resposta = reader.IsDBNull(1) ? "Sem resposta ainda." : reader.GetString(1)
                        };
                    }
                }
            }

            return ticket;
        }

    }
}
