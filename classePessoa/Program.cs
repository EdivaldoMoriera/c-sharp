using System;

namespace classePessoa // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Informe o nome da Pessoa");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da Pessoa");
            p1.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome da Pessoa");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da Pessoa");
            p2.idade = Convert.ToInt32(Console.ReadLine());


            if (p1.idade > p2.idade)
            {
                Console.WriteLine("Maior: p1 "  +p1.nome);

            }
            else
            {
                Console.WriteLine("Maior: p2 " + p2.nome);

            }



        }
    }
}