using System;

namespace DZ5
{
    class Program
    {
        static void Main(string[] args)
        {

            //    //  Задача 2 
            //       // A 
            //        int a = 10, b=15,c=0; 
            //        for(int i = a; i <= b; i++)
            //        { 
            //           c += i; 
            //             Console.WriteLine(c); 
            //       }  
            //      // B
            //       for(int i = a; i <=b; i++)
            //       {            
            //            if(c % 2 != 0){ 

            //                Console.WriteLine(c); 
            //            } 
            //        }  


            //             Задача 3. 
            ////-----------Прямоугольник--------------- 


            Console.WriteLine("\n");
            Console.Write("Прямоугольник");
            Console.WriteLine("\n");
            for (int i = 0; i < 30; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("*                            *");
            }
            for (int i = 0; i < 30; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("\n");

            // ----------- Треугольник ---------------


            Console.WriteLine("\n");

            int a = 0;
            for (int i = 0; i <= 10; i++)
            {
                Console.Write("*");
                for (int y = 0; y <= a; y++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                a += 2;
                Console.WriteLine();
            }
            for (int i = 0; i <= 23; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("\n");



            //------------Равностаронний треугольник -----------------
            Console.Write("Равностаронний треугольник");
            Console.WriteLine("\n");

            int b = 10;
            int c = 0;
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= b; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int z = 0; z < c; z++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
                b--;
                c += 2;
            }
            for (int i = 0; i <= 23; i++)
                Console.Write("*");
            Console.WriteLine("\n");


            // -----Ромб---------


            int d = 10;
            int f = 0;
            for (int y = 0; y <= 5; y++)
            {
                for (int i = 0; i <= d; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 0; i < f; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
                d -= 2;
                f += 4;
            }
            d = 0;
            f = 20;
            for (int y = 0; y <= 5; y++)
            {
                for (int i = 0; i <= d; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 0; i < f; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
                d += 2;
                f -= 4;
            }
            Console.WriteLine("\n");




            double money = 1000;
            double procent = 1;
            int month = 0;
            while (money <= 1100)
            {
                money += money * procent / 100;

            }
            Console.WriteLine("month:" + month);
            Console.WriteLine("money:" + money);










        }
    }
}













