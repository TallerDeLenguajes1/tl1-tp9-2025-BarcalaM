Console.WriteLine("Hola mundo");

using System.IO;
using System;

class Program
{
     static void Main(string[] args)
    {
        string? path;
        string[] carpetas, files;
        do
        {
            Console.WriteLine("Ingresar el path deseado: ");
            path = Console.ReadLine();
            if (!Directory.Exists(path))
            {
                Console.WriteLine("EL directorio no existe. ");
            }
}