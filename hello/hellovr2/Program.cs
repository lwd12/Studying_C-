/*
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace hellover2
{
    static class Constants
    {
        public const int limit = 8;
        public const int limit1 = 5;
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //        //for(int i = 0; i<Constants.limit;i++){
            //        //        for(int a=0;a<Constants.limit-i;a++){
            //        //        Console.Write(' ');
            //        //    }
            //        //        for(int b=0;b<i*2+1;b++){
            //        //        Console.Write("*");
            //        //    }
            //        //    Console.WriteLine();
            //        //}

            //        //for (int i = 0; i< Constants.limit; i++){

            //        //    for(int a=0;a<i;i++){
            //        //        Console.Write(' ');
            //        //    }
            //        //    for(int b =0;b< Constants.limit - i;b++){
            //        //        Console.Write("*");
            //        //    }
            //        //}

            //        //for (int i = 0; i < Constants.limit; i++)
            //        //{
            //        //    for (int a = 0; a < Constants.limit - i; a++)
            //        //    {
            //        //        Console.Write(' ');
            //        //    }
            //        //    for (int b = 0; b < i * 2 + 1; b++)
            //        //    {
            //        //        Console.Write("*");
            //        //    }
            //        //    Console.WriteLine();
            //        //}

            //        //for(int i=0;i< Constants.limit1;i++){
            //        //        for(int a=0;a<i+1;a++){
            //        //        Console.Write("*");
            //        //        }
            //        //        for(int b =0;b<8-i*2;b++){
            //        //        Console.Write(' ');
            //        //    }
            //        //    for (int c = 0; c < i + 1; c++)
            //        //    {
            //        //        Console.Write("*");
            //        //    }
            //        //    Console.WriteLine();
            //        //}
            //        //for (int i = 0; i < Constants.limit1-1; i++)
            //        //{
            //        //    for (int a = 0; a < 4-i; a++)
            //        //    {
            //        //        Console.Write("*");
            //        //    }
            //        //    for (int b = 0; b < i*2+2; b++)
            //        //    {
            //        //        Console.Write(' ');
            //        //    }
            //        //    for (int c = 0; c < 4 - i; c++)
            //        //    {
            //        //        Console.Write("*");
            //        //    }
            //        //    Console.WriteLine();
            //        //}

            //        //for (int i = 0; i < Constants.limit3; i++)
            //        //{
            //        //    for (int a = 0; a < i; a++)
            //        //    {
            //        //        Console.Write('#');
            //        //        if (a > Constants.limit3 / 2)
            //        //        {
            //        //            for (int v = (Constants.limit3 + 1) / 2 - 1; v >= 0; v--)
            //        //            {
            //        //                for (int b = 0; b < (Constants.limit3 / 2 - 0.5) - v; b++)
            //        //                {
            //        //                    Console.Write('$');
            //        //                }
            //        //            }

            //        //            //for(a=0;a< ((Constants.limit3+1)/2-1)-x;a++){
            //        //            //        Console.Write('#');
            //        //            //        x += 1;
            //        //            //    }
            //        //            //}
            //        //        }
            //        //        for (int b = 0; b < Constants.limit3 - i * 2; b++)
            //        //        {
            //        //            Console.Write("*");
            //        //        }
            //        //        Console.WriteLine();
            //        //    }
            //        //}
            Console.WriteLine("홀수를 쓰세요");
            int limit = int.Parse(Console.ReadLine());



            //for(int i=0;i < limit / 2-0.5;i++){
            //    for(int a=0;a<i;a++){
            //        Console.Write(' ');
            //    }
            //    for(int b=0;b< limit - i*2;b++){
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for(int i =0;i< limit / 2 + 0.5;i++){
            //    for(int a=0;a< limit / 2+0.5-(i+1);a++){
            //        Console.Write(" ");
            //    }
            //    for(int b=0;b< i*2+1;b++){
            //        Console.Write("*");
            //    }
            //   Console.WriteLine();
            //}


            for (int i = 0; i < limit; i++)
            {
                int a = (i < (limit - 1) / 2) ? i : limit - 1 - i;

                for (int b = 0; b < a; b++)
                {
                    Console.Write(" ");
                }
                for (int c = 0; c < limit - 2 * a; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }




        }
    }
}
*/