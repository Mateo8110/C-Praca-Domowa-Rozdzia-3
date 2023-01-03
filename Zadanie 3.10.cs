namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            int silnia = 1;
            Console.WriteLine("Podaj n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                silnia = silnia * i;
            }
            Console.WriteLine("Silnia wynosi: {0}", silnia);
            Console.ReadKey();
        }
    }
}

        