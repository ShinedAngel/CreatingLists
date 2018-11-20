using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace aula20_11
{
    class Program
    {
        static void ExemploCollections()
        {
            Queue fila = new Queue();
            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);
            fila.Enqueue(4);

            Console.WriteLine("A fila possui {0} elementos", fila.Count);

            Stack pilha = new Stack();
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);
            pilha.Push(4);

            Console.ForegroundColor = ConsoleColor.Magenta;
            while (pilha.Count > 0)
                Console.WriteLine(pilha.Pop());
            Console.ResetColor();

            int elemento = (int)fila.Dequeue();

             Console.WriteLine("\n");

            Console.WriteLine("O primeiro elemento: " + elemento);

            Console.WriteLine("A fila possui {0} elementos", fila.Count);

            Console.ForegroundColor = ConsoleColor.Magenta;
            while (fila.Count > 0)
                Console.WriteLine(fila.Dequeue());
            Console.ResetColor();

            Console.WriteLine("\n");

            ArrayList lista = new ArrayList();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);

            Console.WriteLine("A lista possui {0} elementos", lista.Count);

            Console.WriteLine("Existe o elemento 2? {0}", fila.Contains(2));

            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int i = 0; i < lista.Count; i++)
                Console.Write(lista[i] + "\t");
            Console.ResetColor();

            Console.WriteLine("\n");

            //Queue = Fila
            //Enqueue = Enfileirar
            //Dequeue = Desinfileirar
        }

        static void Main(string[] args)
        {
            ExemploCollections();

            Console.ReadKey();
        }
    }
}