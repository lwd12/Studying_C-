using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.Reflection;
using System.Security.AccessControl;

namespace hellover4
{
    internal class Program
    {


        class Test {
            public int value = 10;
        }
        static void Change(Test input){
            input.value = 20;
        }
        class MyClass{
            public int MyField1;
            public int MyField2;

    

            
        }

        static class Fibonacci
        {
            private static Dictionary<int, long> memo = new Dictionary<int, long>();
            public static long Get(int n)
            {
                if (n < 0) { return 0; }
                if (n == 1) { return 1; }
                if (memo.ContainsKey(n)) { return memo[n]; }
                else
                {
                    long value = Get(n - 1) + Get(n - 2);
                    memo[n] = value;
                    return value;
                }
            }
        }
        
        static void PrintProfile(string name,string phone=""){
                Console.WriteLine($"Name: {name},Phone: {phone}");
        }

        static class Mathes {
            public static int Plus(int a,int b)
            {
                Console.WriteLine("Calling int Plus");
                return a + b;
            }
            public static int Plus(int a, int b,int c)
            {
                Console.WriteLine("Calling int Plus");
                return a + b+c;
            }
            public static double Plus(double a, double b)
            {
                Console.WriteLine("Calling double Plus1");
                return a + b;
            }
            public static double Plus(int a, double b)
            {
                Console.WriteLine("Calling double Plus2");
                return a + b;
            }

        }
        class Quadrand4{
            public static double seat(double x, double y){
                if (x > 0 && y > 0)
                    Console.WriteLine("제 1사분면");
                else if (x < 0 && y > 0)
                    Console.WriteLine("제2사분면");
                else if (x < 0 && y < 0)
                    Console.WriteLine("제 3사분면");
                else if (x > 0 && y < 0)
                    Console.WriteLine("제 4사분면");
                else
                    Console.WriteLine(" 좌표축 위입니다.");


                return 0;
            }
        }



        class Alpa {
            public static char alpha()
            {
                char a;
                Console.WriteLine("알파벳 문자를 하나 입력하세요");
                a = char.Parse(Console.ReadLine());
                if (a >= 'a' && a <= 'z')
                    return a;
                else
                    Console.WriteLine("알파벳 소문자를 입력해주세요");
                return a;
            }
        }

        class Weight { 
            public static void weight(int a,int b){
                if ((b - 100) * 0.9 > a)
                    Console.WriteLine("저체중입니다");
                else if ((b - 100) * 0.9 < a)
                    Console.WriteLine("과체중입니다");
                else
                    Console.WriteLine("정상입니다");
            }
}
        class Void1 {
            public static void not() { Console.WriteLine("반환형도 없고 매개변수도 없다"); }
        }

        class Animal
        {
            public int Age { get; set; }
            public string Color { get; set; }
            public Animal() { this.Age = 0; }
            public void eat() { Console.WriteLine("냠냠 먹습니다"); }
            public void sleep() { Console.WriteLine("쿨쿨 잠을 잡니다"); }
          

        }

        class Dog : Animal
        {
            
            public void Bark() {
                base.Color = "노란색";
                Console.WriteLine("왈왈 짖습니다"); }

        }
            class Cat : Animal
            {

                
                public void meow() {
                base.Color = "하얀색";
                Console.WriteLine("냥냥 웁니다"); }

            }

        class Parent {
            protected string name;
            public Parent() { Console.WriteLine("1_Parent()"); }
            public Parent(int param) { Console.WriteLine("2_Parent(int param)"); }
            public Parent(string name) { this.name = name; Console.WriteLine("Parent:" + name); }


        }
        class Child : Parent {
        public Child() : base() { Console.WriteLine("1_child():base()"); }
        public Child(int a):base(10) { Console.WriteLine("2_child(): base(10)"); }
        public Child(string name) : base(name) { Console.WriteLine("child:" + name); }




}






        class Base { public bool var = true; }
        class Derived : Base
        {
            static void Main(string[] args)
            {
                //Test test = new Test();
                //test.value = 10;
                //Change(test);

                //Console.WriteLine("클래스로 만들어진 인스턴스의 객체의 메서드 호출후 변화 :" + test.value);

                //MyClass source = new MyClass();
                //source.MyField1 = 10;
                //source.MyField2 = 20;

                //MyClass target = source;
                //target.MyField2 = 30;

                //Console.WriteLine("{0}\t{1}", source.MyField1, source.MyField2);
                //Console.WriteLine("{0}\t{1}", target.MyField1, target.MyField2);

                //Console.WriteLine(Fibonacci.Get(40));
                //Console.WriteLine(Fibonacci.Get(40));


                //PrintProfile("박찬호");
                //PrintProfile("박세리","010222-2222");
                //PrintProfile(name: "박상현");
                //PrintProfile(name: "지성", phone:"01030405");


                //Console.WriteLine(Mathes.Plus(1, 2));
                //Console.WriteLine(Mathes.Plus(1, 2,3));
                //Console.WriteLine(Mathes.Plus(1, 2.1));
                //Console.WriteLine(Mathes.Plus(1.1, 2));

                //double a, b;
                //Console.WriteLine("x축을 입력하세요");
                //a = double.Parse(Console.ReadLine());
                //Console.WriteLine("y축을 입력하세요");
                //b = double.Parse(Console.ReadLine());
                //Quadrand4.seat(a, b);



                //char a = Alpa.alpha();
                //if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
                //    Console.WriteLine("모음입니다");
                //else
                //    Console.WriteLine("자음입니다");


                //int a, b;
                //Console.WriteLine("체중을 입력하세요");
                //a = int.Parse(Console.ReadLine());
                //Console.WriteLine("키를 입력하세요");
                //b = int.Parse(Console.ReadLine());
                //Weight.weight(a,b);


                //List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
                //List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };
                //int count = 0;
                //foreach(var item in Dogs){
                //    count++;
                //    item.eat();
                //    item.sleep();
                //    item.Bark();
                //    Console.WriteLine();
                //}
                //Console.WriteLine("Dogs 호출 횟수 : " + count);
                //count = 0;

                //foreach (var item in Cats)
                //{
                //    count++;
                //    item.eat();
                //    item.sleep();
                //    item.Bark();
                //    Console.WriteLine();
                //}
                // Console.WriteLine("Cats 호출 횟수 :" + count);



                //Dog dog = new Dog();
                //dog.eat();
                //dog.sleep();
                //dog.Bark();
                //dog.Age++;
                //Console.WriteLine("강아지의 나이는" + dog.Age + "살");
                //Console.WriteLine("강아지 색깔 :" + dog.Color);


                //Cat cat = new Cat();
                //cat.eat();
                //cat.sleep();
                //cat.meow();
                //cat.Age++;
                //Console.WriteLine("고양이의 나이는" + cat.Age + "살");

                //Base base0bj = new Base();
                //Derived derived0bj = new Derived();
                //Console.WriteLine("상속 접근한 객체 : {0}", derived0bj.var);
                //Console.WriteLine("직접 접근한 객체 : {0}", base0bj.var);

                List<Animal> Animal = new List<Animal>(){
                    new Dog(),new Cat(),new Dog(),new Cat(),
                    new Dog(),new Cat(),new Dog(),new Cat()
                };

                //foreach(var item in Animal){
                //    //    item.eat();
                //    //    item.sleep();
                //    //    ((Dog)item).Bark();
                //    //    //((Cat)item).meow();


                //    var dog = item as Dog;
                //    if (dog != null) { dog.Bark(); }
                //    var cat = item as Cat;
                //    if (cat != null) { cat.meow(); }
                //}

                Child childA = new Child();
                Child childc = new Child(10);
                Child childB = new Child("Dicaprio");
                


            }
        }  
    }
}
