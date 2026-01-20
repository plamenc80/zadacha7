namespace PermuntaciqVariaciqKombinaciqZadacha7
{
    internal class Program
    {
        static long Fact(int x)
        {
            long f = 1;
            for (int i = 1; i <= x; i++)
                f *= i;
            return f;

        }
        static void Main(string[] args)
        {
            Console.Write("Vuvedete chislo n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Vuvedete chislo k: ");
            int k = int.Parse(Console.ReadLine());
            long permutations = Fact(n) / Fact(n - k);
            long variations = Fact(n) / Fact(n - k);
            long combinations = Fact(n) / (Fact(k) * Fact(n - k));
            Console.WriteLine($"Permutacii: {permutations}");
            Console.WriteLine($"Variacii: {variations}");
            Console.WriteLine($"Kombinacii: {combinations}");
                
        }
    }
}
