using System;

namespace Entidades
{ 
    public class Ticket
    {
        public string Resposta { get; set; }
        public string ID { get; set; }
        public string Titulo { get; set; }
        public string Cliente { get; set; }
        public string Prioridade { get; set; }
        public string Tempo { get; set; }
        public string Status { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int UsuarioId { get; set; }
    }
}
