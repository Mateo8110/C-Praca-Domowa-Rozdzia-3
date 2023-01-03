namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int a;

            do
            {
                Console.WriteLine("Podaj liczbę całkowitą: ");
                a = int.Parse(Console.ReadLine());
                suma += a;
                Console.Clear();
                
            }
            while (a != 0);
            {
                Console.WriteLine("Suma liczb wynosi {0}", suma);
                Console.ReadLine();
            }
            Console.ReadKey();
        }      
    }
}


            
            