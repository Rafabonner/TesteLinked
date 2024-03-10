using System;

class Program
{
    static void Main()
    {
        int Teste = int.Parse(Console.ReadLine());

        for (int i = 0; i < Teste; i++)
        {
            int[] largada = Array.ConvertAll(Console.ReadLine().ToCharArray(), c => int.Parse(c.ToString()));
            int[] chegada = Array.ConvertAll(Console.ReadLine().ToCharArray(), c => int.Parse(c.ToString()));

            int ultrap = CalcularUltrapassagens(largada, chegada);

            Console.WriteLine($"No final foram {ultrap} ultrapassagens");
        }
    }

    static int CalcularUltrapassagens(int[] largada, int[] chegada)
    {
        int ultrap = 0;

        for (int i = 0; i < chegada.Length; i++)
        {
            int posicaoLargada = Array.IndexOf(largada, chegada[i]);

            largada[posicaoLargada] = -1;

            int ultrapassagens = posicaoLargada - i;
            if (ultrapassagens > 0)
            {
                ultrap += ultrapassagens;
            }
        }

        return ultrap;
    }
}