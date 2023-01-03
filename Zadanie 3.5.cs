namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            double delta = 0;
            double pierwiastek = 0;
            double x1, x2, x0;
            Console.WriteLine("Podaj a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            double c = double.Parse(Console.ReadLine());

            delta = (b * b) - (4 * a * c);
            pierwiastek = Math.Sqrt(delta);
            
            if (delta > 0)
            {
                x1 = (-b - pierwiastek) / 2;
                x2 = (-b + pierwiastek) / 2;
                Console.WriteLine("x1 i x2 wynosi: {0}, {1}", x1, x2);
            }
            else if(delta == 0)
            {
                x0 = -b / 2 * a;
                Console.WriteLine("x0 wynosi: {0}", x0);
            }
            else
            {
                Console.WriteLine("Delta ujemna brak rozwiązań");
            }
        Console.ReadKey();
        }
    }
}
        
