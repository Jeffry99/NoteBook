using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.UNA.Helpers
{
    public static class LogIn
    {
        public static Usuario usuario = new Usuario();
        public static bool Validar(string nomUsuario, string contrasena)
        {
            //Agregar codigo para validar con usuarios guardados en el sistema

            if (nomUsuario.Equals("admin") && contrasena.Equals("1234"))
            {
                //Usuario usuario = new Usuario();
                usuario.nombreUsuario = nomUsuario;
                usuario.contraseña = contrasena;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
