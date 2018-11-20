using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula13_11
{
    class Program
    {
        static void Troca(int[] vetor, int posi1, int posi2)
        {
            int aux = 0;
            aux = vetor[posi1];
            vetor[posi1] = vetor[posi2];
            vetor[posi2] = aux;

            Console.WriteLine();
        }

        static void Imprime(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
                Console.Write(vetor[i] + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int posicao1 = 0;
            int posicao2 = 0;

            int[] vetor = new int[] { 12, 6, 14, 10, 26 }; // 0 1 2 3 4 respectivamente

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\n\t");
            Imprime(vetor);
            Console.ResetColor();

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("\n\tDigite a 1ª posição: ");
                posicao1 = Int32.Parse(Console.ReadLine());
            } while (posicao1 < 0 || posicao1 > vetor.Length);

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("\n\tDigite a 2ª posição: ");
                posicao2 = Int32.Parse(Console.ReadLine());
                Console.ResetColor();
            } while (posicao2 < 0 || posicao2 > vetor.Length);

            /* || = ou
             * && = as duas condições ao mesmo tempo */

            Troca(vetor, posicao1, posicao2);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\t");
            Imprime(vetor);
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
