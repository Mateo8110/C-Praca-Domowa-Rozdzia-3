namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            double BMI = 0;
            Console.WriteLine("Podaj swoją wagę w Kg: ");
            double masa = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w m: ");
            double wzrost = double.Parse(Console.ReadLine());

            BMI = masa / (wzrost * wzrost);

            Console.WriteLine("Twoje BMI wynosi: {0}", BMI);

            if (BMI < 18.5)
            {
                Console.WriteLine("Masz niedowagę");
            }
            else if ((BMI > 18.5) && (BMI < 24.99))
            {
                Console.WriteLine("Twoja waga jest prawidłowa");
            }
            else
            {
                Console.WriteLine("Masz nadwagę");
            }
            Console.ReadKey();
        }
    }
}
