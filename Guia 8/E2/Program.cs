using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Archivo archivo = new Archivo();
            double x= 0;
            double y= 0;
            Console.WriteLine("ingrese latitud y longitud");
            x= Convert.ToDouble(Console.ReadLine());
            y= Convert.ToDouble(Console.ReadLine());

            archivo.cosa();
            Console.WriteLine(archivo.Buscar(x,y));
            Console.WriteLine(archivo.BuscarTrabajo(x,y));
        }
    }
}