using System;

namespace ConsoleApp2 
{
    class Program 
    {
        static void Main(string[] args) 
        {
        int hora = 24;
        int totalHoras;
        int dias;
        
        Console.WriteLine("Quantos dias você passou viajando?");
        dias = int.Parse(Console.ReadLine());
        
        totalHoras = dias * hora;
        
        Console.WriteLine("Você passou " + totalHoras + " horas viajando");
        
        Console.ReadKey();
        
        }
    }
}