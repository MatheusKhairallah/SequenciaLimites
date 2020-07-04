using System;

namespace SequenciaLimites
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números inteiros");
            Console.Write("Primeiro número: ");
            int numero1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo número: ");
            int numero2=Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if(numero2<numero1)
            Console.WriteLine("Erro! O segundo número é menor que o primeiro");
            else
            while (numero1<numero2)
            {
                Console.Write($"{numero1} ");
                numero1=numero1+1;
            }
                Console.Write($"{numero2}");




        }
    }
}
