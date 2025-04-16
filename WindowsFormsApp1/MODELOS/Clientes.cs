using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.MODELOS
{
    internal class Clientes
    {
        public string RFC { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public char? EdoCivil { get; set; }
        public int IDUbi { get; set; }
        public DateTime FechaNac { get; set; }
    }
}
