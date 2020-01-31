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
                usuario.TipoUsuario = ObtenerTipoUsuario();
                return true;
            }
        }
        public static int EncontrarIdUsuario()
        {
            int idUsuario = 0;
            try
            {
                
                MysqlAccess mysqlAccess = new MysqlAccess();
                mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
                mysqlAccess.OpenConnection();
                DataTable data = mysqlAccess.QuerySQL("SELECT idUsuarios FROM dbproyecto.usuarios WHERE nombre_usuario = '" + usuario.NombreUsuario + "'");
                idUsuario = Convert.ToInt32(data.Rows[0][0].ToString());
                mysqlAccess.CloseConnection();
                //return idUsuario;
            }
            catch (Exception){}
            return idUsuario;
        }
        
        public static string ObtenerTipoUsuario()
        {
            string tipoUsuario;
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            DataTable data = mysqlAccess.QuerySQL("SELECT tipo_usuario FROM dbproyecto.usuarios WHERE nombre_usuario = '" + usuario.NombreUsuario + "'");
            tipoUsuario = data.Rows[0][0].ToString();
            mysqlAccess.CloseConnection();
            return tipoUsuario;
        }
    }
}
