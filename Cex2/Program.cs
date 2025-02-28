namespace Cex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menu = @"

            1 - Domingo
            2 - Segunda-feira
            3 - Terça-feira
            4 - Quarta-feira
            5 - Quinta-feira
            6 - Sexta-feira
            7 - Sabado";

            Console.WriteLine(menu);
            byte opcao = byte.Parse(Console.ReadLine()!);

            switch (opcao) {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("Dia inválido");
                    break;
            }
        }
    }
}
