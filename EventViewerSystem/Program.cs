using System.IO;
using System;
using System.Globalization;
using EventViewerSystem.Interfaces;

namespace EventViewerSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fichero = @"eventos.txt";

            IReadFile eventos = new ReadFile();
            GetEvents dataEvent = new GetEvents();

            dataEvent.GetDatesOfFile((eventos.ReadFiles(fichero)));

            Console.ReadKey();

            //mensaje bienvenida

            //1. leer -interfaz con su clase
            // regresar string[]

            //2. Obtener datos (separar fecghas/ maper) interfaz con clase
            // separar o mapear en un diccionario o tabla o lista de objetos - metodo publico - regresar una lista
            // validar mapero - privado

            //3. Convertir fechas/ interfaz con clase
            //metodo para transformar fechas a minutos
            //metodo privado para validar conversion

            //4. comparar pasado futuro
            //metodo de comparacion
            //


            //5. Imprimir interfaz con clase
        }
    }
}