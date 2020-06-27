using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Helpers
{
    static class SoporteParaConfiguracion
    {
        public static void CrearArchivoDeConfiguracion(string fileName, string Direccion)
        {
            if (!Directory.Exists(Direccion))
            {
                Directory.CreateDirectory(Direccion);
            }
            BinaryWriter BinArch = new BinaryWriter(File.Open(fileName, FileMode.Create));
            BinArch.Write(Direccion);
            BinArch.Close();
        }
        public static string LeerConfiguracion(string fileName)
        {
            FileStream archivo = new FileStream(fileName, FileMode.Open);
            BinaryReader binary = new BinaryReader(archivo);
            string leido = binary.ReadString();
            binary.Close();
            return leido;
        }
    }
}
