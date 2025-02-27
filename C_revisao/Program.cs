using System.Runtime.Serialization;

namespace C_revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resutado;

            Console.Write("Informe sua primeira nota: ");
            double nota = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe sua segunda nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            double soma = (nota + nota1) / 2;

            if (soma >= 7)
            {
                resutado = "Aprovado";
            }
            else if (soma < 5)
            { 
                resutado = "Reprovado";
            }
            else {
                resutado = "Recuperação";
            }

            Console.WriteLine("A sua nota foi : {0}! Seu resultado final foi: {1}", soma, resutado);
        }
    }
}
