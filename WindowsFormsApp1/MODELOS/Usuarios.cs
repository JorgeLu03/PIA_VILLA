using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.MODELOS
{
    internal class Usuarios
    {
        public int NumNómina { get; set; }
        public DateTime FechaNac { get; set; }
        public string Tel { get; set; }
        public char Tipo { get; set; }
        public bool Estatus { get; set; }
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public int IDPuesto { get; set; }
    }
}
