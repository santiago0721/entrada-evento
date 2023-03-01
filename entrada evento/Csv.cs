using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace entrada_evento
{
    class Csv:Archivo
    {
   
        public Csv(string Archivo) 
        {
            string ruta = @"C:\Users\HOME\source\repos\entrada evento\entrada evento\" + Archivo;
            this.cargar(ruta);
            this.personas(ruta);
        }

        public override void personas(string Archivo)
        { 
            foreach(string persona in datos) 
            {
                char delimitador = ',';
                string[] person = persona.Split(delimitador);
                lista_personas.Add(person);
            }
        }
    }

}
