/*using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hellover3
{
    internal class Program
    {
        public static int instance = 10;

            class MyMath
            {
                public static int Abs(int input)
                {
                    if (input < 0){ return -input;}
                    else
                    return input;
                }
            public static double Abs(double input)
            {
                if (input < 0) { return -input; }
                else
                    return input;
            }
            public static long Abs(long input)
            {
                if (input < 0) { return -input; }
                else
                    return input;
            }
            public static decimal Abs(decimal input)
            {
                if (input < 0) { return -input; }
                else
                    return input;
            }



        }
class Product{
            public static int Counter = 0;
            public int id;
            public string name;
            public int price;

public Product(string name, int price){
                Product.Counter = Counter + 1;
                this.id = Counter;
                this.name = name;
                this.price = price;

            }
        }


            static void Main(string[] args)
            {

            //Console.WriteLine(MyMath.Abs(52));
            //Console.WriteLine(MyMath.Abs(273));
            //Console.WriteLine(instance);

            //while(true){


            //Console.WriteLine("정수를 입력하세요");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("정수형 Abs()메서드 호출{0}", MyMath.Abs(a));
            //Console.WriteLine("실수를 입력하세요");
            //double b = double.Parse(Console.ReadLine());
            //Console.WriteLine("실수형 Abs()메서드 호출{0}", MyMath.Abs(b));
            //Console.WriteLine("실수(decimal)를 입력하세요");
            //decimal c = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("실수(decimal) Abs()메서드 호출{0}", MyMath.Abs(c));

            // }

            //object obj = null;
            //Console.WriteLine("숫자형태로 입력하세요");
            //string s = Console.ReadLine();
            //if (int.TryParse(s, out int out_i))
            //    obj = out_i;
            //else if (float.TryParse(s, out float out_f))
            //    obj = out_f;
            //else
            //    obj = s;

            //switch(obj){
            //    case int i:
            //        Console.WriteLine($"{i}는 int 형식입니다");
            //        break;
            //    case float f:
            //        Console.WriteLine($"{f}는 float 형식입니다");
            //        break;
            //    default:
            //        Console.WriteLine($"{obj}는 모르는 형식입니다");
            //        break;

            //}
            Product productA = new Product("감자", 2000);
            Product productB = new Product("고구마 ", 3000);
            Product productC = new Product("양파", 2500);
            Product productD = new Product("대파", 3000);



            Console.WriteLine(productA.id + ":"+productA.name+ ":" + "{0,10}", productA.price);
            Console.WriteLine(productB.id + ":" + productB.name + ":" + "{0,7}", productB.price);
            Console.WriteLine(productC.id + ":" + productC.name + ":" + "{0,10}", productC.price);
            Console.WriteLine(productD.id + ":" + productD.name + ":" + "{0,10}", productD.price);
            Console.WriteLine(Product.Counter + "개 생성되었습니다.");

        }
    }
}
*/