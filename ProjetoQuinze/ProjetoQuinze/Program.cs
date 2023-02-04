using ProjetoQuinze;
using System;
using System.Globalization;
namespace Exercicio
{
    class ProjetoQuinze
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Name = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.AllSalary = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Tax = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write($"Funcionário: {f.Name}, salário líquido: R${f.LiqSalary()}.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Aumento salarial proposto: ");
            f.IncreasePerc = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write($"Dados atualizados: {f.Name}, R${f.IncreasedSal().ToString("F2", CultureInfo.InvariantCulture)}");
            
            Console.ReadKey();
        }
    }
}