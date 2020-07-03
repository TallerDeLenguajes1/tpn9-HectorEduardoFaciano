using System;
using System.Diagnostics;
using System.IO;

namespace ConversorMorse
{
    class Conversor
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            string fecha = now.ToString("dd-MM-yyyy");
            string direccion = Directory.GetCurrentDirectory();
            string directorio = direccion + @"/Morse/ ";
            string fileName = directorio + "texto.txt";
            string fileNameMorse = directorio + "morse_" + fecha + ".txt";
                        
            string cadena;
            //ingreso una cadena de caracteres
            Console.WriteLine("Ingrese un texto para convertirlo a morse y guardarlo en un archivo: ");
            cadena = Console.ReadLine();
            //convierto la cadena a codigo morse
            string textAmorse = Helpers.ConversorDeMorse.TextoAMorse(cadena);
            Console.WriteLine("Codigo Morse guardado: " + textAmorse);
            //almaceno la cadena de texto en el archivo fileNameMorse
            Helpers.ConversorDeMorse.CrearArchivo(directorio, fileNameMorse, textAmorse);
            string nuevaCad = Helpers.ConversorDeMorse.LeerMorse(fileNameMorse);
            string morseAtext = Helpers.ConversorDeMorse.MorseATexto(nuevaCad);
            Console.WriteLine("Codigo convertido a texto: " + morseAtext);
            Helpers.ConversorDeMorse.CrearArchivo(directorio, fileName, morseAtext);
            FileInfo ruta = new FileInfo(fileName);
            Console.WriteLine("Archivos guardados en: " + ruta.Directory);
        }
    }
}
