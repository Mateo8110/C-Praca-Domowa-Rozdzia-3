namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj przedział od <1,n>");
            Console.WriteLine("Podaj n:");
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int suma = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        suma += j;
                }
                if (suma == i)
                    Console.WriteLine("Liczba {0} jest liczbą doskonałą", i);
            }
            Console.ReadKey();
  
        }
    }
}