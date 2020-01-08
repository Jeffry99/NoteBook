using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.UNA.Helpers
{
    public class Accion
    {
        public string Fecha
        {
            get;
            set;
        }
        public string Usuario
        {
            get;
            set;
        }
        public string _Accion
        {
            get;
            set;
        }
        public string Objeto
        {
            get;
            set;
        }
        public string InfoAdicional
        {
            get;
            set;
        }

        public Accion(string usuario, string accion, string objeto, string infoAdicional)
        {
            this.Fecha = DateTime.Now.ToString();
            this.Usuario = usuario;
            this._Accion = accion;
            this.Objeto = objeto;
            this.InfoAdicional = infoAdicional;
        }


    }
}
