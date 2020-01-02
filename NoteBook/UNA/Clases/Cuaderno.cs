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

        public string nombre
        {
            get;
            set;
        }

        public string categoria
        {
            get;
            set;
        }

        public string color
        {
            get;
            set;
        }

        public int orden
        {
            get;
            set;
        }
    }
}