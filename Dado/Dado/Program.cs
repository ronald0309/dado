using System;

namespace Dado
{
    class Program
    {
        void imprimirDado(int superior, int caraFrontal, int laterales)
        {
            int max = 7;
            imprimirSuperior(superior);
            imprimirCaraFrontal(caraFrontal,laterales);
            imprimirInferior(7 - superior);

        }
        void imprimirSuperior(int superior)
        {
            Console.WriteLine("             ########");
            Console.WriteLine("             #      #");
            Console.WriteLine("             #   {0}   #",superior);
            Console.WriteLine("             #      #");

        }
        void imprimirCaraFrontal(int caraFrontal, int laterales)
        {
            int max = 7;
            Console.WriteLine("############################");
            Console.WriteLine("#     #      #      #      #");
            Console.WriteLine("#  {0}   #  {1}    #  {2}    #   {3}   #",7-caraFrontal,7-laterales,caraFrontal,laterales);
            Console.WriteLine("#     #      #      #      #");
            Console.WriteLine("#############################");
        }
        void imprimirInferior(int inferior)
        {
            Console.WriteLine("             #      #");
            Console.WriteLine("             #  {0}    #",inferior);
            Console.WriteLine("             #      #");
            Console.WriteLine("             ########");
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int x;
            int x2;
            int x3;
            int x4;
            int X5;
            int x6;

            do
            {
               
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    x = random.Next(1, 4);
                    do
                    {
                        x2 = random.Next(1, 4);
                    } while (x == x2);
                    do
                    {
                        x3 = random.Next(1, 4);
                    } while (x == x3 || x2==x3);
                    Console.WriteLine("Nueva Visualizacion {0},{1},{2}", x,x2,x3);
                   // imprimirDado(x,x2,x3);
                }
            } while (Console.ReadKey().Key == ConsoleKey.Escape);


        }
    }
}
