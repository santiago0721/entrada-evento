using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace entrada_evento
{
    internal class Hakerman

    {
        Validador validador;
        public Hakerman(Validador validador_inicial) 
        {
            Console.WriteLine("bienvenido a hakerman , por este medio puedes ingresar");
            validador = validador_inicial;
            
        }

        public List<string[]> cambiar() 
        {
            Console.WriteLine("ingrese su id");
            string id = Console.ReadLine(); 
            (bool en_lista, int posicion) = validador.Validar_en_lista(id);
            if (en_lista)
            {
                while (true)
                {
                    Console.WriteLine("ingrese los nuevos datos");
                    Console.WriteLine("correo");
                    string correo = Console.ReadLine();
                    Console.WriteLine("edad");
                    string edad = Console.ReadLine();
                    validador.lista[posicion][2] = correo;
                    validador.lista[posicion][3] = edad;

                    if (validador.Validar_persona(id).Item2)
                    {
                        return validador.lista;
                    }   
                }
            }
            Console.WriteLine("usted no esta en la lista , no puedo hacer nada ");
            return validador.lista;
        }
    }
}
