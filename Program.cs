using System;
using System.Collections.Generic;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o ranger da matriz");
            int n = int.Parse(Console.ReadLine());
            int[,] x = new int[n, n];
            //carregando os dados para a matris
            for (int y = 0; y < n; y++) {
                for (int k = 0; k < n; k++) {
                    Console.WriteLine("escreva o elemento nas posições ("+y+","+k+")");
                    x[y, k] = int.Parse(Console.ReadLine());
                }
            }

            //imprimir na tela as diagonáis 
            for (int i = 0; i < n; i++) {
                Console.Write(x[i,i].ToString());
            }


            Console.WriteLine("____________conjuntohash__________________");
            HashSet<int> conjunto = new HashSet<int> {1,2,3,4,9,6 };
            foreach (int z in conjunto) {
                Console.WriteLine(z);
            }
            int val = 5;

            if (conjunto.Contains(val))
            {
                Console.WriteLine("contem 5");
            }
            else {
                Console.WriteLine("não contem 5");
            }




        }
    }
}
