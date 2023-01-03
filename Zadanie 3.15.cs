namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Na ile sposobów można wypłacić 10 złotych");
            for (int k1 = 0; k1 <= 10; k1++)
            {
                for (int k2 = 0; k2 <= 10; k2++)
                {
                    for (int k3 = 0; k3 <= 10; k3++)
                    {
                        if (k1 * 1 + k2 * 2 + k3 * 5 == 10)
                            Console.WriteLine("Złotówka = {0} Dwa Złote = {1} Pięć Złotych = {2}",
                                k1, k2, k3);

                    }
                }
            }
            Console.ReadKey();
        }
    }
}