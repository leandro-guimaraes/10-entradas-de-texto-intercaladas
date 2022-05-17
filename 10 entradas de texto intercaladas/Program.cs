using System;

namespace _10_entradas_de_texto_intercaladas
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string[] vetorNomes = new string[10];
            int[] inomes = new int[10];

            for (int i = 0; i < vetorNomes.Length; i++)
            {
                Console.WriteLine("Insira um nome: " +i );
                vetorNomes[i]= Convert.ToString(Console.ReadLine());
                Console.Clear();
            }
            for(int i = 0; i < vetorNomes.Length; i++)
            {
                Console.WriteLine(vetorNomes[i]  +" \r\n -ou-");
                
            }

        }
    }
}
