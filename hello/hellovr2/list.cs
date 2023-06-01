using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace hellover2
{

    class Member
    {
        public string Name = "scv";
        public int Mineral = 50;
        public int supply = 1;
        public int HP = 45;
        public int Attack = 5;
    }

    internal class list
    {

        class Student
        {
            public string name;
            public int grade;
        }
        class Pet
        {

            public string name;
            public int Age;
        }
        class Person
        {

            public string name = "홍길동";
            public string address = "서울특별시 강서구";

            List<Pet> pet = new List<Pet>
            {
             new Pet(){name = "구름", Age = 7} ,
             new Pet(){name = "별", Age = 1 }
            };

            public void show()
            {
                foreach (var item in pet)
                {
                    Console.WriteLine("Person pets :" + item.name);
                    Console.WriteLine("person pets: " + item.Age + "살");
                }
            }

        }
        class Lens
        {
            public int a;
            public Lens(int b){
                a = b;
            }

            }

            class Test{
            
                public int Power(int x, int y){
                return x * y;
            }
                public void sum(int b,int c){
                int a=0;

                for (int i = b; i <= c; i++){
                    a += i;
                    }
                Console.WriteLine(a);
            }


        }

            static void Main(string[] args)
            {
                //List<Student> list = new List<Student>();
                //list.Add(new Student() { name = "윤인성", grade = 1 });
                //list.Add(new Student() { name = "연하진", grade = 2 });
                //list.Add(new Student() { name = "윤아린", grade = 3 });
                //list.Add(new Student() { name = "윤명월", grade = 4 });
                //list.Add(new Student() { name = "구지연", grade = 1 });
                //list.Add(new Student() { name = "김연화", grade = 2 });

                List<Student> list = new List<Student>()
            {
            new Student() { name = "윤인성", grade = 1 },
            new Student() { name = "연하진", grade = 2 },
            new Student() { name = "윤아린", grade = 3 },
            new Student() { name = "윤명월", grade = 4 },
            new Student() { name = "구지연", grade = 1 },
            new Student() { name = "김연화", grade = 2 },
            };


                //for(int i= list.Count-1; i>0;i--)
                //{
                //    if (list[i].grade > 1)
                //        list.RemoveAt(i);
                //}

                //foreach (var item in list)
                //{
                //    Console.WriteLine(item.name + ":" + item.grade);
                //}


                //Member member = new Member();
                //Console.WriteLine("Name :" + member.Name);
                //Console.WriteLine("Mineral :" + member.Mineral);
                //Console.WriteLine("Supply :" + member.supply);
                //Console.WriteLine("HP :" + member.HP);
                //Console.WriteLine("Attack :" + member.Attack);



                //Person person = new Person();
                //Console.WriteLine("person name :"+person.name);
                //Console.WriteLine("person address :"+person.address);
                //person.show();

                //Console.WriteLine("숫자를 입력하세요");
                Random random = new Random();

            //int b = random.Next(0, 50);
            //while (true){
            //    int a = int.Parse(Console.ReadLine());
            //    if (a == b)
            //    {
            //        Console.WriteLine("정답입니다");
            //        break;
            //    }
            //    else if (a < b)
            //    {
            //        Console.WriteLine(" 답보다 작은 수 입니다");
            //    }
            //    else
            //        Console.WriteLine(" 정답보다 큰 수입니다.");

            //}

            int[] INT32 = new int[6];
            byte[] BYTES = new byte[6];
            double[] DOUBLE = new double[6];


            random.NextBytes(BYTES);

           for (int i = 0; i<6;i++){
                INT32[i] = random.Next();
                DOUBLE[i] = Math.Round(random.NextDouble(),2);

            }

            for (int i = 1; i <= 6; i++) {
                Console.WriteLine("개수: {0}", i);
                Console.Write("{0,-16 }" ,"random int32 :");
                Console.WriteLine("{0,16}", INT32[i-1]);
                Console.Write("{0,-16 }", "random double :");
                Console.WriteLine("{0,16}", DOUBLE[i-1]);
                Console.Write("{0,-16 }", "random byte :");
                Console.WriteLine("{0,16}", BYTES[i-1]);
                Console.WriteLine();

            }
            //Console.WriteLine("숫자를 입력하세요");



            //Lens[] lens = new Lens[5];
            //for (int i = 1; i <= 5; i++)
            //{
            //int ab = int.Parse(Console.ReadLine());
            ////lens[i].a = new Lens(ab);

            //}
            //for(int i = 0;i<5;i++){
            //    Console.WriteLine(lens[i]);
            //}

            Test test = new Test();
            //Console.WriteLine(test.Power(10,20));
            //Console.WriteLine(test.Power(20,13));

            //Console.WriteLine("숫자를 입력하세요");

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(test.Power(a,b));
            //test.sum(10,100);
            }
        
    }
}

