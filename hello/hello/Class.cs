using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{

    class Product
    {
        public string name;
        public int price;

    }
    
   internal class Class
    {

      

        class Cat{

            public string Name;
            public string Color;

            public void Meow(){
                Console.WriteLine($"{Name}:야옹");
            }
        }


        class Carspeed{
            private int Speed;

            public int speed {  
                set{
                    if (value >= 0)
                    this.Speed = value;
                }
             }

            public void up(){Speed += 20;}

            public void down(){Speed -= 10; }

public void show(){Console.WriteLine($"현재 스피드:{Speed}");}
        }


      static void Main()
        {
            /*
            Cat kitty = new Cat();
            kitty.Name = "키티";
            kitty.Color = "하얀색";
            kitty.Meow();
            Console.WriteLine($"{kitty.Name}:{kitty.Color}");

            Cat nero = new Cat();
            nero.Name = "네로";
            nero.Color = "검은색";
            nero.Meow();
            Console.WriteLine($"{nero.Name}:{nero.Color}");
            */

            //Carspeed carspeed = new Carspeed();
            //carspeed.speed = 0;
            //carspeed.up();
            //carspeed.up();
            //carspeed.show();
            //carspeed.down();
            //carspeed.show();


            Random random = new Random();
            //for (int i = 0; i < 5; i++)
            //    Console.WriteLine(random.Next(10, 100));

            Random random1 = new Random();
            //for (int i = 0; i < 5; i++)
            //    Console.WriteLine(random.NextDouble()*10);
            double seat = Math.Round(random.NextDouble(),5);
            //Console.WriteLine(seat);

            //List<double> list = new List<double>();
            //list.Add(52);
            //list.Add(25);
            //list.Add(62);
            //list.Add(seat);
            //foreach(var item in list){
            //    Console.WriteLine("Count" + list.Count + "\t item:" + item);
            //}





            //List<string> rivers = new List<string>(new string[]{
            //"signal","math","express"
            //});
            //rivers.Add("hello");
            //rivers.Add("bye");
            //rivers.Remove("math");
            //List<string> range = rivers.GetRange(1, 3);
            //foreach(string river in range){
            //    Console.WriteLine(river);
            //}
            //Console.WriteLine(rivers[0][0]);
            //Console.WriteLine("ABS: " + Math.Abs(-52236));
            //Console.WriteLine("Ceiling" + Math.Ceiling(52.236));
            //Console.WriteLine("Floor" + Math.Floor(52.773));
            //Console.WriteLine("Mat" + Math.Max(52, 236));


            Product product = new Product();
            product.name = "감자";
            product.price = 2000;

            Console.WriteLine(product.name + ":" + product.price+"원");
            Product productA = new Product() { name = "감자", price = 2000 };
            Console.WriteLine($"{ productA.name}:{productA.price}");

            


        }


    }
}
