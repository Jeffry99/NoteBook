using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoteBook
{
    public class Cuaderno
    {
        public List<Nota> notas = new List<Nota>();

        public string Nombre
        {
            get;
            set;
        }

        public string Categoria
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }

        public int Orden
        {
            get;
            set;
        }
    }
}