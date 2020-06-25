using System;

namespace Aula24Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade fibonacci = new Recursividade();
            //System.Console.WriteLine(fibonacci.GerarFatorial(5));
            //fibonacci.GerarSequenciaFibonacci(0,1,5);
            fibonacci.GerarTribonacci(0,1,2,20);
        }
    }
}
