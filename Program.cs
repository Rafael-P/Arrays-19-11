using System;

namespace Arrays_19_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 19-11");

            string[] nomes = new string[5];
            int[] idades = new int[5];

            for (var contador = 0; contador < 5; contador++)
            {
                Console.WriteLine($"Digite o {contador+1}º nome");
                nomes[contador] = Console.ReadLine();
                Console.WriteLine("Digite a idade");
                idades[contador] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Nomes Cadastrados:");

            for (var contador = 0; contador < 5; contador++)
            {
                Console.WriteLine("Nome: "+nomes[contador]);
                Console.WriteLine("Idade: "+idades[contador]);
            }

        }//FIM DO MAIN
    }
}
