using PIA_VILLA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Text.RegularExpressions;

namespace PIA_VILLA
{
    public static class Validaciones
    {
        // Valida que un campo no est� vac�o
        public static bool ValidarCampoNoVacio(string campo, out string mensajeError)
        {
            if (string.IsNullOrWhiteSpace(campo))
            {
                mensajeError = "Los campos no pueden estar vac�os.";
                return false;
            }
            mensajeError = string.Empty;
            return true;
        }

        // Valida que un nombre sea v�lido (solo letras y espacios)
        public static bool ValidarNombre(string nombre, out string mensajeError)
        {
            if (!Regex.IsMatch(nombre, @"^[a-zA-Z������������\s]+$"))
            {
                mensajeError = "El nombre solo puede contener letras y espacios.";
                return false;
            }
            mensajeError = string.Empty;
            return true;
        }

        // Valida que un correo electr�nico sea v�lido
        public static bool ValidarCorreo(string correo, out string mensajeError)
        {
            if (!Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                mensajeError = "El correo electr�nico no tiene un formato v�lido.";
                return false;
            }
            mensajeError = string.Empty;
            return true;
        }

        // Valida que un n�mero de tel�fono sea v�lido (solo d�gitos, longitud m�nima y m�xima)
        public static bool ValidarTelefono(string telefono, out string mensajeError)
        {
            if (!Regex.IsMatch(telefono, @"^\d{10}$"))
            {
                mensajeError = "El n�mero de tel�fono debe contener exactamente 10 d�gitos.";
                return false;
            }
            mensajeError = string.Empty;
            return true;
        }

        // Valida que una contrase�a cumpla con los requisitos m�nimos
        public static bool ValidarContrasena(string contrasena, out string mensajeError)
        {
            bool esValida = contrasena.Length >= 5 &&
                            Regex.IsMatch(contrasena, @"[A-Z]") &&
                            Regex.IsMatch(contrasena, @"[a-z]") &&
                            Regex.IsMatch(contrasena, @"\d");

            if (!esValida)
            {
                mensajeError = "La contrase�a debe tener al menos 5 caracteres, una letra may�scula, una letra min�scula y un n�mero.";
                return false;
            }

            mensajeError = string.Empty;
            return true;
        }


        // Valida que un campo num�rico est� dentro de un rango
        public static bool ValidarNumeroEnRango(int numero, int minimo, int maximo, out string mensajeError)
        {
            if (numero < minimo || numero > maximo)
            {
                mensajeError = $"El n�mero debe estar entre {minimo} y {maximo}.";
                return false;
            }
            mensajeError = string.Empty;
            return true;
        }
    }
}
