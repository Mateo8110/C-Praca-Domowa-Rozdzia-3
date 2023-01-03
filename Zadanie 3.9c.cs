namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę wierszy: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                    
                    
                }
                 Console.WriteLine("*");
            }
            
            
            Console.ReadKey();
        }
    }
}