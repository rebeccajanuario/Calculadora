using System;

namespace ExercicioCalculadora
{
    class Calculadora
    {
        public static void Main(string[] args)
        {
            //Desenvolvendo uma calculadora

            //Inicializando as variáveis
            double val1, val2;

            //Entrada de números
            Console.WriteLine("Digite o primeiro valor: ");
            val1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            val2 = double.Parse(Console.ReadLine());

            //realiza a soma
            Console.WriteLine("Soma = {0}", val1 + val2);

            //realiza a subtração
            Console.WriteLine("Subtração = {0}", val1 - val2);

            //realiza a multiplicação
            Console.WriteLine("Multiplicação = {0}", val1 * val2);

            //realiza a divisão
            Console.WriteLine("Divisão = {0}", val1 / val2);

            Console.WriteLine("\nNão volte mais aqui !");
        }
    }
}
