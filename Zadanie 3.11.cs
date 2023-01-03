namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            int ileLiczb = 1;
            int suma = 0;
            int poczatek = 0;

            while (suma <= 100)
            {
                ileLiczb++;
                suma = suma + poczatek;
                poczatek++;
                Console.WriteLine(suma);
                

            }
            Console.WriteLine("Ilość potrzebnych liczb {0} a suma wynosi {1}", ileLiczb, suma);
            Console.ReadKey();

        }
    }
}