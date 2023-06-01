using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace hellover3
{
    internal class Carpicture
    {
        private int car_width;
        private int car_height;
        private string car_name;
        private Color color;


        public Carpicture(int car_width, int car_height, string car_name, Color color)
        {
            if (car_width > 0 && car_height > 0)
            {
                this.car_width = car_width;
                this.car_height = car_height;
                this.car_name = car_name;
                this.color = color;
            }
            else
                Console.WriteLine("너비와 높이는 0이상으로 입력해주세요");
        }
        public int getWidth { get { return this.car_width; } }
        public int setWidth
        {
            set
            {
                if (value > 0)
                    this.car_width = value;
            }
        }
        public int getHeight { get { return this.car_height; } }
        public int setHeight
        {
            set
            {
                if (value > 0)
                    this.car_height = value;
            }
        }
    }
    internal class option
    {
        class Aerial {
            private double width;
            private double height;
            private double high;

            public Aerial(double width, double height, double high)
            {
                if (width > 0 && height > 0 && high>0)
                {
                    this.width = width;
                    this.height = height;
                    this.high = high;
                }
                else
                    Console.WriteLine("너비와 높이는 0이상으로 입력해주세요");
            }

            

            public Aerial(){
            width =100;
            height=100;
            high=50;
            }

            public double Aer(double a,double b,double c){
                double res = a * b * c;
                return res;
            }


            public double Width
            {
                get { return this.width; }
                set
                {
                    if (value > 0)
                        this.width = value;
                }
            }
            public double Height
            {
                get { return this.height; }
                set
                {
                    if (value > 0)
                        this.height = value;
                }
            }
            public double High
            {
                get { return this.high; }
                set
                {
                    if (value > 0)
                        this.high = value;
                }
            }
        }



        static void Main(string[] args)
        {
            //Carpicture carpicture = new Carpicture(200, 20, "santafe", Color.Brown);
            //Console.WriteLine(carpicture.getWidth +","+ carpicture.getHeight);
            //carpicture.setWidth = 100;
            //carpicture.setHeight = 100;
            //Console.WriteLine(carpicture.getWidth + "," + carpicture.getHeight);

            Aerial aerial = new Aerial();
            Console.WriteLine(aerial.Width + "," + aerial.Height + "," + aerial.High);
            

            aerial = new Aerial(50, 20, 100);
            Console.WriteLine(aerial.Width + "," + aerial.Height + "," + aerial.High);



            Console.WriteLine(aerial.Aer(aerial.High, aerial.Height, aerial.Width));




        }
    }
}
