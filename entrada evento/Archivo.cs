using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace entrada_evento
{
    abstract class Archivo
    {
        public List<string> datos;
        public List<string[]> lista_personas = new List<string[]>();
        public void cargar(string archivo) 
        {
            try
            {
                datos = new List<string>();
                StreamReader x = new StreamReader(archivo);
                x.BaseStream.Seek(0, SeekOrigin.Begin);

                string contenedor = x.ReadLine();

                while (contenedor != null)
                {
                    datos.Add(contenedor);
                    contenedor = x.ReadLine();
                }

                x.Close();
            }
            catch (System.IO.FileNotFoundException)
            {
                throw new No_se_encuentra_archivo();
            }
        }

        public abstract void personas(string Archivo);


    }
}
