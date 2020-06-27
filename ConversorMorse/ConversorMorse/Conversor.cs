using System;
using System.Diagnostics;
using System.IO;

namespace ConversorMorse
{
    class Conversor
    {
        static void Main(string[] args)
        {
            string direccion_final = "./Mover/";
            string direccion_inicial = "./ ";
            string fileName = "destino.dat";
                        
            string cadena;
            //ingreso una cadena de caracteres
            Console.WriteLine("Ingrese un texto para convertirlo a morse y guardarlo en un archivo: ");
            cadena = Console.ReadLine();
            //convierto la cadena a codigo morse
            string textAmorse = Helpers.ConversorDeMorse.TextoAMorse(cadena);
            Console.WriteLine("Codigo Morse guardado: " + textAmorse);
            //almaceno la cadena de texto en el archivo destino.dat
            Helpers.ConversorDeMorse.CrearMorse(direccion_inicial, fileName, cadena);
            string nuevaCad = Helpers.ConversorDeMorse.LeerMorse(fileName);
            Console.WriteLine("Codigo convertido nuevamente a texto: " + nuevaCad);
            FileInfo ruta = new FileInfo(fileName);
            Console.WriteLine("Revisar archivos guardados en: " + ruta.Directory);
        }
    }
}