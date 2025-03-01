using System.Transactions;

namespace Cex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu nome: ");
            string nome = Console.ReadLine()!;

            Console.Write("Informe o números de horas trabalhadas? ");
            int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o seu salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            double resultado = horasTrabalhadas * salario;

            Console.WriteLine($"A renda total de {nome}foi de R${resultado:F2}");
        }
    }
}
