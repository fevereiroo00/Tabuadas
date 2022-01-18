using System;

namespace Fevereiro_tabuadas
{
    class Program
    {
        static int n;
        
        static void Main(string[] args)
        {

            int v = 1;
            string d;

            while(v != 0)
            {
                Console.WriteLine("Digi-te um numero. Esse numero vai ser feito para formar a respetiva tabuada");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("Tabuada do" + n);

                    Console.WriteLine(n + "*" + i + "="+n*i);
                }
                Console.WriteLine("Prentende continuar ?");
                d = Console.ReadLine();

                if (d == "Sim" )
                {

                }
                else if (d == "Não")
                {
                    Environment.Exit(0);
                }




            }
            

        }
    }
}
