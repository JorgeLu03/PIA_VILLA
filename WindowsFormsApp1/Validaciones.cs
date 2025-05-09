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
        // Valida que un campo no esté vacío
        public static bool ValidarCampoNoVacio(string campo, out string mensajeError)
        {
            if (string.IsNullOrWhiteSpace(campo))
            {
                mensajeError = "Los campos no pueden estar vacíos.";
                return false;
            }
            mensajeError = string.Empty;
            return true;
        }

        // Valida que un nombre sea válido (solo letras y espacios)
        public static bool ValidarNombre(string nombre, out string mensajeError)
        {
            if (!Regex.IsMatch(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                mensajeError = "El nombre solo puede contener letras y espacios.";
                return false;
            }
            mensajeError = string.Empty;
            return true;
        }

        // Valida que un correo electrónico sea válido
        public static bool ValidarCorreo(string correo, out string mensajeError)
        {
            if (!Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                mensajeError = "El correo electrónico no tiene un formato válido.";
                return false;
            }
            mensajeError = string.Empty;
            return true;
        }

        // Valida que un número de teléfono sea válido (solo dígitos, longitud mínima y máxima)
        public static bool ValidarTelefono(string telefono, out string mensajeError)
        {
            if (!Regex.IsMatch(telefono, @"^\d{10}$"))
            {
                mensajeError = "El número de teléfono debe contener exactamente 10 dígitos.";
                return false;
            }
            mensajeError = string.Empty;
            return true;
        }

        // Valida que una contraseña cumpla con los requisitos mínimos
        public static bool ValidarContrasena(string contrasena, out string mensajeError)
        {
            bool esValida = contrasena.Length >= 5 &&
                            Regex.IsMatch(contrasena, @"[A-Z]") &&
                            Regex.IsMatch(contrasena, @"[a-z]") &&
                            Regex.IsMatch(contrasena, @"\d");

            if (!esValida)
            {
                mensajeError = "La contraseña debe tener al menos 5 caracteres, una letra mayúscula, una letra minúscula y un número.";
                return false;
            }

            mensajeError = string.Empty;
            return true;
        }


        // Valida que un campo numérico esté dentro de un rango
        public static bool ValidarNumeroEnRango(int numero, int minimo, int maximo, out string mensajeError)
        {
            if (numero < minimo || numero > maximo)
            {
                mensajeError = $"El número debe estar entre {minimo} y {maximo}.";
                return false;
            }
            mensajeError = string.Empty;
            return true;
        }
    }
}
