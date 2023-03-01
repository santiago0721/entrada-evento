using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace entrada_evento
{
    class Taquilla
    {
        Validador validador;
        public Taquilla()
            
        {
            validador = this.ruta();
            this.menu();


        }

        public Validador ruta() 
        {
            Archivo lectura;
            Console.WriteLine("ingrese la ruta");
            string archivo = Console.ReadLine();
            try
            {

                if (archivo.EndsWith("txt"))
                { lectura = new Txt(archivo); }

                else if (archivo.EndsWith("csv"))
                { lectura = new Csv(archivo); }

                else
                {
                    throw new no_existe_tipo_de_archivo();
                }
                validador = new Validador(lectura.lista_personas);
            }
            catch (no_existe_tipo_de_archivo) 
            {
                Console.WriteLine("ingrese un tipo de archivo valido");
                this.ruta();
            }
            catch(No_se_encuentra_archivo)
            {
                Console.WriteLine("no se encuentra este archivo, ingrese otra ruta");
                this.ruta();    
            }

            return validador;  
        }
        public void menu()
        {
            while (true)
            {
                Console.WriteLine("ingrese id");
                string id = Console.ReadLine();
                string s = validador.Validar_persona(id);
                Console.WriteLine(s);

                Console.WriteLine("si desea ver otro invitado presione enter , " +
                    "de lo contrario presione cualquier letra y enter ");
               var respuesta = Console.ReadLine();
                if (respuesta != "") { break; }
            }
            
        }
   
    }

    }




