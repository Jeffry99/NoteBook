using DatabaseAccess.UNA;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.UNA.Helpers
{
    public static class RegistroAcciones
    {
        public static int IdUsuario
        {
            get;
            set;
        }
        public static void Save(Accion accion)
        {
            
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            DataTable data = mysqlAccess.QuerySQL("SELECT idUsuarios FROM dbproyecto.usuarios WHERE nombre_usuario = '"+accion.Usuario+"'");
            IdUsuario = Convert.ToInt32(data.Rows[0][0]);
            Console.WriteLine("IDusuario: " + IdUsuario);

            mysqlAccess.EjectSQL("INSERT INTO dbproyecto.transacciones (fecha, idUsuario, accion, objeto, info_adicional) VALUES " +
            "('" + DateTime.Now.ToString() + "','" + IdUsuario + "','" + accion._Accion + "','" + accion.Objeto + "','" + accion.InfoAdicional + "')");
            
            mysqlAccess.CloseConnection();
        }

        public static DataTable Load()
        {
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            DataTable data = mysqlAccess.QuerySQL("SELECT idUsuario, accion, objeto, info_adicional, fecha FROM dbproyecto.transacciones");

            mysqlAccess.CloseConnection();
            return data;
        }
        public static string ObtenerNombreUsuario()
        {
            string nombreUsuario = "";
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            DataTable data = mysqlAccess.QuerySQL("SELECT nombre_usuario FROM dbproyecto.usuarios WHERE idUsuarios = '"+IdUsuario+"'");
            mysqlAccess.CloseConnection();
            nombreUsuario = data.Rows[0][0].ToString();
            return nombreUsuario;
        }


    }
}
