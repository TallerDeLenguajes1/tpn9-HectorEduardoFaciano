using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Helpers
{
    static class ConversorDeMorse
    {
        readonly static Dictionary<char, string> diccionario = new Dictionary<char, string>()
        {
            {'a', ".-"},
            {'b', "-..."},
            {'c', "-.-."},
            {'d', "-.."},
            {'e', "."},
            {'f', "..-."},
            {'g', "--."},
            {'h', "...."},
            {'i', ".."},
            {'j', ".---"},
            {'k', "-.-"},
            {'l', ".-.."},
            {'m', "--"},
            {'n', "-."},
            {'o', "---"},
            {'p', ".--."},
            {'q', "--.-"},
            {'r', ".-."},
            {'s', "..."},
            {'t', "-"},
            {'u', "..-"},
            {'v', "...-"},
            {'w', ".--"},
            {'x', "-..-"},
            {'y', "-.--"},
            {'z', "--.."},
            {' ', "/" }
        };

        public static string TextoAMorse(String texto)
        {
            texto = texto.ToLower();
            string morse = "";

            foreach (char caracter in texto.ToCharArray())
            {
                morse += diccionario[caracter] + " ";
            }

            return morse;
        }

        public static string MorseATexto(String morse)
        {
            string texto = "";

            foreach (string codigo in morse.Split(" "))
            {
                foreach (KeyValuePair<char, string> res in diccionario)
                {
                    if (res.Value == codigo)
                    {
                        texto += res.Key;
                    }
                }
            }
            return texto;
        }
    
        public static void CrearMorse(string ubicacion, string nombre, string contenido)
        {
            Directory.CreateDirectory(ubicacion);
            FileStream archivo = new FileStream(ubicacion + nombre, FileMode.Create);
            StreamWriter stream = new StreamWriter(archivo);
            stream.Write(contenido);
            stream.Close();
        }

        public static string LeerMorse(string pathArchivo)
        {
            FileStream archivo = new FileStream(pathArchivo, FileMode.Open);
            StreamReader stream = new StreamReader(archivo);
            string leido = stream.ReadToEnd();
            stream.Close();
            return leido;
        }

    }
}