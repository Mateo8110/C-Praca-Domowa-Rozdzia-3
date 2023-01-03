namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int n;
            Console.WriteLine("Wczytaj n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    suma -= i;
                }
                else
                {
                    suma += i;
                }
            }
            Console.WriteLine("Suma wynosi: {0}",suma);
            Console.ReadKey();
        }
    }
}