using System.Globalization;

/* System.Console.WriteLine("Informe o numero inteiro");
int n1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Você digutou :" + n1);

System.Console.WriteLine("Informe o numero Double");
double n2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
System.Console.WriteLine("Você digutou :" + n2.ToString("F2",CultureInfo.InvariantCulture));

System.Console.WriteLine("Informe o numero O char");
char c = Convert.ToChar(Console.ReadLine());
System.Console.WriteLine("Você digutou :" + c); 

string[] vet = Console.ReadLine().Split(' ');
string nome = vet[0];
char sexo = char.Parse( vet[1]);
int idade = int.Parse(vet[2]);
double altura = double.Parse( vet[3], CultureInfo.InvariantCulture);
Console.WriteLine(nome);
Console.WriteLine(sexo);
Console.WriteLine(idade);
Console.WriteLine(altura);*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
         /*    Console.WriteLine("Digite um numero");
            double x = double.Parse(Console.ReadLine());
            while (x>=0.0)
            {
                 double raiz = Math.Sqrt(x);
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Digite outro numero");
            x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                
            }
           System.Console.WriteLine("Numero"); */

           Console.Write("Quantos numero você irá Digitar:");
           int N  = int.Parse(Console.ReadLine());

           int soma = 0;
           for(int i = 0; i<= N; i++){
            Console.Write(" A Soma é #{0} : " , i);
            int valor = int.Parse(Console.ReadLine());
            soma += valor;
            System.Console.Write("Soma igual " + soma);

           }
           
        }
     
    }
   
   
}





