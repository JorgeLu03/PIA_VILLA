using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.MODELOS
{
    internal class ClienteCanRsv
    {
        public int IDCliente_CancelaRsv { get; set; }
        public string RFC { get; set; }
        public string CodRsv { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
