namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            double max = 0;
            Console.WriteLine("Podaj 1 liczbe: ");
            double liczba1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj 2 liczbe: ");
            double liczba2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj 3 liczbe: ");
            double liczba3 = double.Parse(Console.ReadLine());

            if ((liczba1 > liczba2) && (liczba1 > liczba3) && (liczba1 > max))
            {
                Console.WriteLine("Największa liczba to:{0} ", liczba1);
            }
            else
            {
                if ((liczba2 > liczba3) && (liczba2 > liczba1) && (liczba2 > max))
                {
                    Console.WriteLine("Największa liczba to: {0} ", liczba2);

                }
                else
                {
                    Console.WriteLine("Największa liczba to:{0} ", liczba3);
                }
            }
            Console.ReadKey();
        }

    }


            

            

        }