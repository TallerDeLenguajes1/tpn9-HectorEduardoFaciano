using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConversorMorse
{
    class Organizador
    {
        static void Main(string[] args)
        {
            string direccion = Directory.GetCurrentDirectory();
            string nombre_archivo = "destino.dat";
            string direccion_destino = direccion + @"\CarpetaDestino\";
            Helpers.SoporteParaConfiguracion.CrearArchivoDeConfiguracion(nombre_archivo, direccion_destino); 
            Console.WriteLine("\n Archivo de configuracion creado ");
            string dir = Helpers.SoporteParaConfiguracion.LeerConfiguracion(nombre_archivo);
            foreach (string archi in Directory.GetFiles(direccion))
            {
                if (archi.EndsWith(".txt") || archi.EndsWith(".mp3"))
                {
                    try
                    {
                        Directory.Move(archi, dir + Path.GetFileName(archi));
                        Console.WriteLine("\n" + archi + " movido a " + dir);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("No se pudo mover: " + archi);
                    }

                }
            }
        }
    }
}
/*
1. Organizar los archivos dentro del directorio.
Para funcionar, el programa que se construirá utilizará un archivo de configuración que
esté escrito en binario, donde se indicará el directorio donde deberá copiar los datos:
● Crear una clase Estática dentro de un nuevo Espacio de Nombres llamado
Helpers con el nombre SoporteParaConfiguracion que tendrá dos métodos:
○ CrearArchivoDeConfiguracion tendrá la capacidad de crear archivos
.dat (con el cual podrá crear el archivo detino.dat)
○ LeerConfiguracion leerá el archivo.dat
● El sistema deberá listar todos los archivos en el directorio raíz del programa
(“carpeta_del_proyecto\bin\debug\”) y seleccionará solamente los que sean de
extensión.mp3 y.txt y los moverá al directorio establecido en el archivo binario
detino.dat.
Para esta tarea puede usar la clase:
System.IO.Path que le permitirán trabajar con rutas de archivos.
Otra forma de resolverlo es utilizando los métodos aprendidos con la
clase Directory y combinarlos con los métodos de el objeto string*/