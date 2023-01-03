namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj Rok: ");
            double rok = double.Parse(Console.ReadLine());

            if ((rok % 4 == 0 && rok % 100 != 0) || rok%400 == 0)
            {
                Console.WriteLine("Rok jest przestępny");
            }
            else
            {
                Console.WriteLine("Rok nie jest przestepny");
            }
            Console.ReadKey();
        }
    }
}