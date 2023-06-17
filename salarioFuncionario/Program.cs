// See https://aka.ms/new-console-template for more information


using System;

namespace salarioFuncionario // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
Funcionario func1  = new Funcionario();
Funcionario func2 = new Funcionario();

Console.WriteLine("Informe o nome do funcionario");
func1.nome = Console.ReadLine();
Console.WriteLine("Informe o Salario do funcionario");
func1.salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o nome do funcionario");
func2.nome = Console.ReadLine();
Console.WriteLine("Informe o Salario do funcionario");
func2.salario = Convert.ToDouble(Console.ReadLine());

 double media = (func1.salario + func2.salario)/2;

 Console.WriteLine("A Media Salarial é " + media );




        }
    }
}
