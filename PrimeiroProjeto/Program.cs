

internal class Program
{

    public static void Main(string[] args)
    {
        for (int i = 0; i <= 2; i++)
        {
            double n1, n2, media;
            Console.WriteLine("Informe o nome do aluno");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe a primeira nota");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota");
            System.Console.WriteLine();
            n2 = Convert.ToDouble(Console.ReadLine());
            media = (n1 + n2) / 2;
            if (media >= 6)
            {
                Console.WriteLine("O Aluno " + nome + " Ficou com a media " + media.ToString("F2") + " Aluno Aprovado");
            }
            else
            {
                Console.WriteLine($" o Aluno {nome} ficou com a Media {media:F2} e está Reprovado");

            }

        }
    }

}
