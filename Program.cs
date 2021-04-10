using System;

namespace Decisoes
{
    class Program
    {
        private const int V = 10;

        static void Main(string[] args)
        {
            decimal n1, n2, n3, n4, resu;

            Console.Write("Digite o primeiro número..: ");
            n1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o segundo número..: ");
            n2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o terceiro número..: ");
            n3 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o quarto número..: ");
            n4 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

                resu = (n1 + n2 + n3 + n4) / 4;

                if (resu > 6 && resu <= 10) {


                     Console.WriteLine($"Sua nota é {resu:N1}");

                     Console.WriteLine();

                     Console.ForegroundColor = ConsoleColor.Green;
                     Console.WriteLine($"Você foi aprovado. Parabéns!");
                     Console.ResetColor();

                } else if (resu < 5 && resu >= 0) {
                    

                    Console.WriteLine($"Sua nota é {resu:N1}");

                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Você foi reprovado...");
                    Console.ResetColor();


                } else if (resu >= 5 && resu <= 6) {       


                    Console.Write($"Sua nota é {resu:N1}");

                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Você está em recuperação. Estude mais!");
                    Console.ResetColor();

                } else if (resu < 0 && resu > 10) {
            
                    Console.Write($" INVÁLIDO. ({resu:N1})");

                    Console.WriteLine();

                    Console.Write("Apenas aceito notas de 0 á 10.");


                }




        }
    }
}
