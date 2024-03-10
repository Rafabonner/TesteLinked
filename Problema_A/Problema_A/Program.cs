using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int numeroBrinquedos = int.Parse(input[0]);
        int altura = int.Parse(input[1]);
        if (altura <= 300)
        {
            input = Console.ReadLine().Split();
            int[] alturasMinimas = Array.ConvertAll(input, int.Parse);

            int quantidadeBrinquedos = alturasMinimas.Count(alturaMinima => altura >= alturaMinima);

            Console.WriteLine("A quantidade de brinquedos é: " + quantidadeBrinquedos);
        }
        else
        {
            Console.WriteLine("Altura muito grande pra ser verdade");
        }
        
     
    }
}