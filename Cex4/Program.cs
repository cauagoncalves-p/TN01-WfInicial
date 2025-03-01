namespace Cex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o 1º Numero: ");
            int num1 = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o 2º Numero: ");
            int num2 = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o 3º Numero: ");
            int num3 = int.Parse(Console.ReadLine()!);


            int maior = Math.Max(num1, num2);
            maior = Math.Max(maior, num3);
            Console.WriteLine("O maior numero é o {0}", maior);
        }
    }
}
