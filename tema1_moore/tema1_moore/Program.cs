using System;


namespace tema1_moore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            uint n;

            Console.WriteLine(" Introduceti un numar natural n, pentru a afla in cat timp procesorul va deveni de n-ori mai puteric fata de momentul actual:");
            while (true)
            {
                Console.Write("Introduceti un numar natural:");
                input = Console.ReadLine();
                if (uint.TryParse(input, out n))
                {
                    double ani;
                    ani = 1.5 * Math.Log(n, 2);
                    Console.WriteLine("Procesorul va fi mai rapid de " + n + " ori in " + ani + " ani");
                    Console.WriteLine("Procesorul va fi mai rapid de {0} ori in {1} ani", n, ani);
                    break;
                }
                else
                {
                    Console.WriteLine("Introduceti un numar natural!\n");
                }
            }
        }
    }
}