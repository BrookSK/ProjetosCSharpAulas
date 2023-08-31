internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite dois números para serem somados");

        int numero1 = Convert.ToInt32(Console.ReadLine());
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"A soma dos números é {Soma(numero1, numero2)}");
    }

    public static int Soma(int numero1, int numero2)
    {
        return numero1 + numero2;
    }
}