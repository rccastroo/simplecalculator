using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite O segundo número: ");
            int numeber2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Selecione a operação: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int operation = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            switch (operation)
            {
                case 1:
                    result = number1 + numeber2;
                    break;
                case 2:
                    result = number1 - numeber2;
                    break;
                case 3:
                    result = number1 * numeber2;
                    break;
                case 4:
                    result = number1 / numeber2;
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }

            Console.WriteLine("O resultado é: " + result);
        }
        
    }
}
