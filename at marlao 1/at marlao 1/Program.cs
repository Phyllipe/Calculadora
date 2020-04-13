using System;

namespace at_marlao_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CALCULADORA x = new CALCULADORA();
            Console.WriteLine("soma");
            x.AddNumero(Convert.ToDouble(Console.ReadLine()));
            x.AddNumero(Convert.ToDouble(Console.ReadLine()));

            System.Console.WriteLine(x.Somar());


            Console.WriteLine("multiplicação");
            x.AddNumero(Convert.ToDouble(Console.ReadLine()));
            x.AddNumero(Convert.ToDouble(Console.ReadLine()));

            System.Console.WriteLine(x.Multi());


            Console.WriteLine("subtração");
            x.AddNumero(Convert.ToDouble(Console.ReadLine()));
            x.AddNumero(Convert.ToDouble(Console.ReadLine()));

            System.Console.WriteLine(x.Subtrair());


            Console.WriteLine("divisão");
            x.AddNumero(Convert.ToDouble(Console.ReadLine()));
            x.AddNumero(Convert.ToDouble(Console.ReadLine()));

            System.Console.WriteLine(x.Divisao());


            Console.WriteLine("Quadrado");
            x.AddNumero(Convert.ToDouble(Console.ReadLine()));
            


            System.Console.WriteLine(x.quadrado());
            







        }
    }
}
