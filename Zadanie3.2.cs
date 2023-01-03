namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 1 liczbę: ");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj 2 liczbę: ");
            int liczba2 = int.Parse(Console.ReadLine());

            if (liczba1 % liczba2 == 0)
            {
                Console.WriteLine("2 liczba jest dzilenikiem liczby 1");
            }
            else
            {
                Console.WriteLine("2 liczba nie jest dzielnikiem liczby 1");
            }
            Console.ReadKey();
        }
        
    }
}

