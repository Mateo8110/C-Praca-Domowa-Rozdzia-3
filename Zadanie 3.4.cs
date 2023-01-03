namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 1 liczbę: ");
            double liczba1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Jaką operację chcesz wykonać? Wypisz znak");
            Console.WriteLine("Dodawanie '+' ");
            Console.WriteLine("Odejmowanie '+'");
            Console.WriteLine("Iloczyn '*' ");
            Console.WriteLine("Iloraz '/'");
            

            string działanie = Console.ReadLine();
            double wynik = 0;

            
            Console.WriteLine("Podaj 2 liczbę: ");
            double liczba2 = double.Parse(Console.ReadLine());

            switch (działanie)
            {
                case "+":
                    wynik = liczba1 + liczba2;
                    Console.WriteLine("Wynik to: {0}", wynik);
                    break;
                case "-":
                    wynik = liczba1 - liczba2;
                    Console.WriteLine("Wynik to: {0}", wynik);
                    break;
                case "*":
                    wynik = liczba1 * liczba2;
                    Console.WriteLine("Wynik to: {0}", wynik);
                    break;
                case "/":
                    wynik = liczba1 / liczba2;
                    Console.WriteLine("Wynik to: {0}", wynik);
                    break;
                    default:
                    Console.WriteLine("Nieznana wartosć");
                    break;
            }
            Console.ReadKey();
        }
    }
}
