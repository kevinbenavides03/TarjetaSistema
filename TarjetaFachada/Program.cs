using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Necesario para usar los subsitemas
using Subsitemas;

namespace PatronFachada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos la instancia de la fachada 
            CFachada fachada = new CFachada();

            //Hacemos uso de los subsitemas a traves de la interfaz
            //sencialla de la fachada 
            fachada.Compra();

            Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-------");
        }
    }
}