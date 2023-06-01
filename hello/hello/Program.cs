/*using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
//using static System.Console;

namespace hello
{
    internal class MainApp
    {

        static void Main(string[] args)
        {

            //Console.WriteLine(DateTime.Now.Year);
            //Console.WriteLine(DateTime.Now.Month);
            //Console.WriteLine(DateTime.Now.Day);
            //Console.WriteLine(DateTime.Now.Hour);
            //Console.WriteLine(DateTime.Now.Minute);
            //Console.WriteLine(DateTime.Now.Second);
            //Console.WriteLine(DateTime.Now.ToLongTimeString());


            //if (DateTime.Now.Hour < 12)
            //{
            //    Console.WriteLine("오전입니다");
            //}
            //else
            //    Console.WriteLine("오후입니다");
            /*           
           if (DateTime.Now.Hour <= 11)
                Console.WriteLine("아침먹을 시간입니다");
            
            else if ( DateTime.Now.Hour < 15)
                Console.WriteLine("점심 먹을 시간입니다");
            
            else 
                Console.WriteLine("저녁먹을 시간입니다");
            

            //Console.WriteLine("학점을 입력하세요");
            //string a = Console.ReadLine();
            //float b = float.Parse(a);

            //if (b == 4.5)
            //    Console.WriteLine("신");
            //else if (b >= 4.2)
            //    Console.WriteLine("교수님의 사랑");
            //else if (b >= 3.5)
            //    Console.WriteLine("현제제의 수호자");
            //else if (b >= 2.8)
            //    Console.WriteLine("일반인");
            //else if (b >= 2.3)
            //    Console.WriteLine("일탈을 꿈꾸는 선구자");
            //else if (b >= 1.75)
            //    Console.WriteLine("오락문화의 선구자");
            //else if (b >= 1.0)
            //    Console.WriteLine("불가촉 천민");
            //else if (b >= 0.5)
            //    Console.WriteLine("자벌레");
            //else 
            //    Console.WriteLine("플랑크톤");
            /*
            Console.WriteLine("숫자를 입력하세요");
            int a = int.Parse(Console.ReadLine());

            switch (a % 2)
            {
                case 0:
                    Console.WriteLine("짝수입니다");
                    break;
                case 1:
                    Console.WriteLine("홀수입니다.");
                    break;
            }
            

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
            //        Console.WriteLine($"{i}는 int 형식입니다.");
            //        break;
            //    case float f :
            //        Console.WriteLine($"{f}는 float 형식입니다.");
            //        break;
            //    default:
            //        Console.WriteLine($"{obj}는 모르는 형식입니다.");
            //        break;
            //}


            //Console.WriteLine("입령: ");
            //string line = Console.ReadLine();

            //if (line.Contains("안녕"))
            //{
            //    Console.WriteLine("안녕하세요");

            //}

            //else
            //    Console.WriteLine("ㅅㅅ!");


            //Console.WriteLine("콘솔키를 입력하시오");
            //ConsoleKeyInfo info = Console.ReadKey();

            //switch(info.Key){
            //    case ConsoleKey.UpArrow:
            //        Console.WriteLine("위로 이동");
            //        break;
            //    case ConsoleKey.RightArrow:
            //        Console.WriteLine("오른쪽으로 이동");
            //        break;
            //    case ConsoleKey.DownArrow:
            //        Console.WriteLine("아래로 이동");
            //        break;
            //    case ConsoleKey.LeftArrow:
            //        Console.WriteLine("왼쪽으로 이동");
            //        break;

            //}
/*
                        Console.WriteLine("태어난 년도를 입력하세요");
                        int a = int.Parse(Console.ReadLine());
                        switch (a % 12)
                        {
                            case 0:
                                Console.WriteLine($"{a} 원숭이띠입니다.");
                                break;
                            case 1:
                                Console.WriteLine($"{a} 닭띠입니다.");
                                break;
                            case 2:
                                Console.WriteLine($"{a} 개띠입니다.");
                                break;
                            case 3:
                                Console.WriteLine($"{a} 돼지띠입니다.");
                                break;
                            case 4:
                                Console.WriteLine($"{a} 쥐띠입니다.");
                                break;
                            case 5:
                                Console.WriteLine($"{a} 소띠입니다.");
                                break;
                            case 6:
                                Console.WriteLine($"{a} 호랑이띠입니다.");
                                break;
                            case 7:
                                Console.WriteLine($"{a} 토끼띠입니다.");
                                break;
                            case 8:
                                Console.WriteLine($"{a} 용띠입니다.");
                                break;
                            case 9:
                                Console.WriteLine($"{a} 뱀띠입니다.");
                                break;
                            case 10:
                                Console.WriteLine($"{a} 말띠입니다.");
                                break;
                            case 11:
                                Console.WriteLine($"{a} 양띠입니다.");
                                break;

            }
            */
            //Console.WriteLine("숫자를 입력하세요");
            //int a = int.Parse(Console.ReadLine());

            //switch (a % 2)
            //{
            //    case 0:
            //        Console.WriteLine("짝수입니다");
            //        break;
            //    case 1:
            //        Console.WriteLine("홀수입니다.");
            //        break;
            //}


            /*
            Console.WriteLine("숫자를 입력하세요");
            int b = int.Parse(Console.ReadLine());

            if (b > 10 && b < 20)
                Console.WriteLine("조건에 맞습니다.");
            else
                Console.WriteLine("아닙니다");
                



            /*
            Console.WriteLine("알파벳 문자 하나를 입력하세요");
            //string b = Console.ReadLine();
            char b = char.Parse(Console.ReadLine());

            if (b == 'a' || b == 'e' || b == 'i' || b == 'o' || b == 'u')
                Console.WriteLine($"{b}는 모음입니다");

            else
                Console.WriteLine($"{b}는 자음입니다");
            

            /*
             Console.WriteLine("체중을 입력하세요");
             int a = int.Parse(Console.ReadLine());
             Console.WriteLine("키를 입력하세요");
             int b = int.Parse(Console.ReadLine());
             Console.WriteLine((b - 100) * 0.9);
             if ((b - 100) * 0.9 == a)
                 Console.WriteLine("표준체중입니다");
             else if ((b - 100) * 0.9 > a)
                 Console.WriteLine("저체중입니다");
             else
                Console.WriteLine("과체중입니다");
             

            Console.WriteLine("x값을 입력하세요");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("y값을 입력하세요");
            int b = int.Parse(Console.ReadLine());

            if (a > 0 && b > 0)
                Console.WriteLine("1사분면입니다.");
            else if (a > 0 && b < 0)
                Console.WriteLine("4사분면입니다.");
            else if (a < 0 && b < 0)
                Console.WriteLine("3사분면입니다.");
            else if (a < 0 && b > 0)
                Console.WriteLine("2사분면입니다.");
            else
                Console.WriteLine("선 위입니다.");



        }
    }
}*/
