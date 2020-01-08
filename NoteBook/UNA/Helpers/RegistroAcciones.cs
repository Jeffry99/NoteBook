using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.UNA.Helpers
{
    public static class RegistroAcciones
    {
        public static List<Accion> acciones = new List<Accion>();

        public static void SaveToFile()
        {
            string output = JsonConvert.SerializeObject(acciones);
            string path = @".\RegistroAcciones.json";
            
            if (!File.Exists(path))
            {
                File.WriteAllText(path, output);
            }
            else
            {
                File.Delete(path);
                File.WriteAllText(path, output);
            }
        }

        public static void LoadFile()
        {
            string path = @".\RegistroAcciones.json";

            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                acciones = JsonConvert.DeserializeObject<List<Accion>>(readText);
            }
            else
            {
                acciones = new List<Accion>();
            }
        }

    }
}
