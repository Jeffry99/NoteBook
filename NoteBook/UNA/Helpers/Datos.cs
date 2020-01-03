using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.UNA.Miscelaneo
{
    public static class Datos
    {
        public static List<Cuaderno> cuadernos;

        public static void SaveToFile()
        {
            string output = JsonConvert.SerializeObject(cuadernos);
            string path = @".\cuadernos.json";

            // This text is added only once to the file.
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
            string path = @".\cuadernos.json";

            // This text is added only once to the file.
            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                cuadernos = JsonConvert.DeserializeObject<List<Cuaderno>>(readText);
            }
            else
            {
                cuadernos = new List<Cuaderno>();
            }
        }
    }
}
