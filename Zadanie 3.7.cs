namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz nr dnia tygodnia: ");
            string numer = Console.ReadLine();

            switch (numer)
            {
                case "1":
                    Console.WriteLine("Poniedziałek");
                    break;

                case "2":
                    Console.WriteLine("Wtorek");
                    break;
                case "3":
                    Console.WriteLine("Środa");
                    break;
                case "4":
                    Console.WriteLine("Czwartek");
                    break;
                case "5":
                    Console.WriteLine("Piątek");
                    break;
                case "6":
                    Console.WriteLine("Sobota");
                    break;
                case "7":
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("wartosc nieprawidłowa");
                    break;
            }
            Console.ReadKey();
        }
    }
}
