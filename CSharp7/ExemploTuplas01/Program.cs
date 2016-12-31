using System;

namespace ExemploTuplas01
{
    class Program
    {
        static void Main(string[] args)
        {
            (int, int) parValores = (7, 49);
            Console.WriteLine($"Valor = {parValores.Item1} ----- " +
                              $"Quadrado = {parValores.Item2}");

            var coordenadas = (latitude: "23.5505° S", longitude: "46.6333° W");
            Console.WriteLine($"São Paulo - " +
                              $"Latitude = {coordenadas.latitude} - " +
                              $"Longitude = {coordenadas.longitude}");

            Console.ReadKey();
        }
    }
}