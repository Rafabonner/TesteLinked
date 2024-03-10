using System;
using System.Linq;

class Program
{
    static void Main()
    {

        int competidores = int.Parse(Console.ReadLine());
        int minClas = int.Parse(Console.ReadLine());
        int[] pontuacoes = new int[competidores];
        for (int i = 0; i < competidores; i++)
        {
            pontuacoes[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(pontuacoes, (a, b) => b.CompareTo(a));

        int clas = ContarClassificados(pontuacoes, minClas);

        Console.WriteLine("O Numero de classificados é: " + clas);
    }

    static int ContarClassificados(int[] pontuacoes, int k)
    {
        int pontuacaoMinima = pontuacoes[k - 1];

        int classificados = pontuacoes.Count(pontuacao => pontuacao >= pontuacaoMinima);

        return classificados;
    }
}