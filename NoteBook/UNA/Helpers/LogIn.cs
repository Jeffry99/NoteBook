using DatabaseAccess.UNA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook.UNA.Helpers
{
    public static class LogIn
    {
        public static Usuario usuario = new Usuario();
        public static bool ValidarUsuario(string nomUsuario, string contrasena)
        {
            //Agregar codigo para validar con usuarios guardados en el sistema
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            DataTable usuarios = mysqlAccess.QuerySQL("SELECT * FROM dbproyecto.usuarios WHERE nombre_usuario = " + "'" + nomUsuario + "'" +
            "AND contraseña = " + "'" + contrasena + "'");
            mysqlAccess.CloseConnection();
            
            if (usuarios.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                usuario.NombreUsuario = nomUsuario;
                usuario.Contrasena = contrasena;
                usuario.TipoUsuario = "Administrador";
                return true;
                

            }
        }
    }
}
