namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Jaka jest średnia twoich ocen?");
            double srednia = double.Parse(Console.ReadLine());

            if ((srednia > 2.00) && (srednia < 3.99))
            {
                Console.WriteLine("Kwota stypednium wynosi 0 zł");
            }
            else if ((srednia > 4.00) && (srednia < 4.79))
            {
                Console.WriteLine("Kwota stypendium wynosi 350 zł");
            }
            else
            {
                Console.WriteLine("Kwota stypendium wynosi 550 zł");
            }
            Console.ReadKey();
        }
    }
}