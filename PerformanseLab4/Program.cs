using System;
//pseudogenerator uniformna raspodjela
namespace PerformanseLab4
{
    class Program
    {
        static decimal PredvidjenoPi = 3.14159265358979323846264338327M;
       
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int opcije;
            do
            {
                Console.WriteLine("Odaberite opciju: ");
                Console.WriteLine("\t1. Broj generisanih vrijednosti.\n\t2. Broj decimala koje treba da se poklope sa pravom vrijednoscu.");
                int.TryParse(Console.ReadLine(), out opcije);
                Console.Clear();
            }
            while (opcije != 1 && opcije != 2);
            if(opcije==1)
            {
                long total=0;
                long circle=0;
                double distanca = 0;
                double x = 0, y = 0;
                decimal PosmatranoPi = 0;
                do
                {
                    Console.WriteLine("Unesite ukupan broj tacaka: ");
                    long.TryParse(Console.ReadLine(), out total);
                }
                while (total <= 0);
                for(int i=0;i<total;i++)
                {
                    x = randomGenerator.NextDouble();
                    y = randomGenerator.NextDouble();//Console.WriteLine($"x: {x},y: {y}");
                    distanca = Math.Sqrt((x * x) + (y * y));//Console.WriteLine($"distanca: {distanca}");
                    if (distanca<1)
                    {
                        circle++;
                    }

                }//Console.WriteLine($"total: {total},circle: {circle}");
                PosmatranoPi =((decimal)circle / (decimal)total)*4;

                Console.WriteLine($"Posmatrano PI:\t{PosmatranoPi}");
                Console.WriteLine($"Predvidjeno PI:\t{PredvidjenoPi}");
            }
            else
            {
                int broj = 0;
                decimal PosmatranoPi = 0;
                double x=0, y=0,distanca=0;
                int circle=0, total=0;
                do
                {
                    Console.WriteLine("Unesite broj decimala koje treba da se poklope sa pravom vrijednoscu: ");
                    int.TryParse(Console.ReadLine(), out broj);
                    Console.Clear();
                }
                while (broj < 1);
                decimal tmp2=2.575436M;
                while(isEqualDecimals(PredvidjenoPi,PosmatranoPi,broj)==false)
                {
                    x = randomGenerator.NextDouble();
                    y = randomGenerator.NextDouble();//Console.WriteLine($"x: {x},y: {y}");
                    total++;
                    distanca = Math.Sqrt((x * x) + (y * y));//Console.WriteLine($"distanca: {distanca}");
                    if (distanca < 1)
                    {
                        circle++;
                    }
                    PosmatranoPi = ((decimal)circle / (decimal)total) * 4;
                   

                }
                Console.WriteLine($"Posmatrano PI:\t{PosmatranoPi}\nPredvidjeno PI:\t{PredvidjenoPi}\nBroj iteracija:\t{total}");
            }
        }

        static bool isEqualDecimals(decimal vrijednost1, decimal vrijednost2,int broj)
        {
            int tmp1,tmp2;
            tmp1 = (int)vrijednost1;
            tmp2 = (int)vrijednost2;
            if (tmp1 == tmp2)
            {
                long pretvoreni1, pretvoreni2;
                pretvoreni1 =(long) (vrijednost1 * (decimal)Math.Pow(10, broj));
                pretvoreni2 = (long)(vrijednost2 * (decimal)Math.Pow(10, broj));
                if (pretvoreni1 == pretvoreni2)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
    }
}
