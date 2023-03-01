using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrada_evento
{
    class Txt : Archivo

    {
        public Txt(string Archivo)
        {
            string ruta = @"C:\Users\HOME\source\repos\entrada evento\entrada evento\" + Archivo;
            this.cargar(ruta);
            this.personas(ruta);
        }

        public override void personas(string Archivo)
        {
            foreach (string persona in datos)
            {
                string[] person = persona.Split();
                lista_personas.Add(person);
            }
        }


    }
}
