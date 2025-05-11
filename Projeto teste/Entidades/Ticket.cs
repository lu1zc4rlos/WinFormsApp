using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ticket
    {
        public int Id_Ticket { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Prioridade { get; set; }
        public string Status { get; set; }
        public int Usuario_Id { get; set; } // FK
        public DateTime Data_Criacao { get; set; }

    }
}
