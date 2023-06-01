/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;




namespace hello
{
    internal class Class_test1
    {
        static void Main()
        {
            Carpicture carpicture = new Carpicture();



            Console.WriteLine("속성을 지정해 초기화 되어 있는 첫번째 생성자에서의 출력");
            Console.WriteLine("{0}:{1}","자동차의 길이",carpicture.Width);
            Console.WriteLine("자동차의 높이" + carpicture.Height);
            Console.WriteLine("자동차의 이름: " + carpicture.car_name);
            Console.WriteLine("자동차의 색깔: " + carpicture.color);

            Console.WriteLine();
            Console.WriteLine("set을 통한 속성에 값 입력");
            carpicture.Width = 300;
            Console.WriteLine("{0}:{1}", "자동차의 길이2", carpicture.Width);
            carpicture.Height = 250;
            Console.WriteLine("자동차의 높이2:" + carpicture.Height);

            Console.WriteLine();
            Console.WriteLine("4개의 파라미터를 갖는 생성자의 필드 출력");
            Carpicture carpicture2 = new Carpicture(210, 160, "Santape", Color.Brown);
            Console.WriteLine("{0}:{1}", "파라미터를 갖는 자동차의 길이", carpicture2.Width);
            Console.WriteLine("파라미터를 갖는 생성자의 자동차의 높이" + carpicture2.Height);
            Console.WriteLine("파라미터를 갖는 생성자의 자동차의 이름: " + carpicture2.car_name);
            Console.WriteLine("파라미터를 갖는 생성자의 자동차의 색깔: " + carpicture2.color);

            Console.WriteLine();
            Console.WriteLine("계산하는 속성 추가");
            Console.WriteLine("자동차의 면적:" + carpicture2.area);

            Console.WriteLine();
            Console.WriteLine("메서드 호출");
            carpicture2.MakeCar();

            Console.WriteLine();
            carpicture2.ProcessStarted += carpicture2_ProcessStarted1;
            carpicture2.ProcessEnded += carpicture2_ProcessEnded;
            carpicture2.MakeCar();
      
        }

    private static void carpicture2_ProcessStarted1(object sender, EventArgs e){
            Console.WriteLine("Process Started");
        }
    private static void carpicture2_ProcessEnded(object sender, EventArgs e){
            Console.WriteLine("Process Ended");
        }




    }
}*/
