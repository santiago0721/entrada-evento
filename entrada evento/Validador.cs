using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace entrada_evento
{
    class Validador

    {
        List<string[]> lista;
        public Validador(List<string[]> lista_personas) 
        {
            lista = lista_personas;
        }

        private bool validar_edad(int indice) 
        {
            string[] persona = lista[indice];
            if (int.Parse(persona[3]) > 17) { return true; }
            else
            { return false; }
        }

        private (bool,int) Validar_en_lista(string id)
        {   int contador = 0;
            foreach (string[] persona in lista) 
            {
                if (persona[1] == id) { return (true, contador); }
                contador++;
            }
            return (false,0);
        }

        private bool validar_email(int indice) 
        {
            (bool conector, int indice_conector) = validar_conector(indice);
            
            if (validar_primer_caracter(indice) & conector)
            {
                if (validar_dominio(indice,indice_conector) & validar_terminacion(indice))
                    { return true; }
            } 
            return false;
        }

        private bool validar_terminacion(int indice) 
        {
            List<string> terminaciones = new List<string> {".com",".co",".edu.co",".org"};
            string correo = lista[indice][2];

            foreach (string terminacion in terminaciones) 
            {
                if (correo.EndsWith(terminacion)) { return true; }
            }
            return false;

        }

        private bool validar_primer_caracter(int indice) 
        {
            char primer_caracter = lista[indice][2][0];
            string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string letras_min = letras.ToLower();

            if (letras.Contains(primer_caracter))
            { return true; }

            else if (letras_min.Contains(primer_caracter))
            {
                { return true; }
            }

            else
            { return false; }
        }

        private (bool,int) validar_conector(int indice) 
        {
            string email_persona = lista[indice][2];

            int contador = 0;
            foreach(Char l in email_persona) 
            {
                if ("@" == l.ToString())
                { return (true, contador); }
                else
                { contador++; }
            }
            return (false, contador);
        }

        private bool validar_dominio(int indice,int indice_)
        {
            List<string> dominios = new List<string> { "gmail", "hotmail", "live" };
            string correo = lista[indice][2];
            string correo_cortado = correo.Substring(indice_ + 1).Split('.')[0];
           
            foreach(string dominio in dominios) 
            {
                if (dominio == correo_cortado) { return true; }
            }
            return false;
        }

        public string Validar_persona(string id) 
        {
            bool persona_en_lista;
            int indice_persona;
            (persona_en_lista,indice_persona)= Validar_en_lista(id);

            if (persona_en_lista)
            {
                if (validar_edad(indice_persona))
                {
                    if (validar_email(indice_persona)) 
                    {
                        return "esta persona puede ingresar";
                    }
                    else { return "correo invalido , No puede entrar"; }
                }
                else
                    return "no tiene la edad suficiente";
            }
            else
                return "no se encontro la persona en la lista";
        }

    }
}
