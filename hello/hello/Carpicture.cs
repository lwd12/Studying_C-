using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace hello
{
    internal class Carpicture
    {
        private int car_width;
        private int car_height;
        //private string car_name;
        //private Color color;
        public string car_name;
        public Color color;

        public Carpicture(){
            car_width = 200;
            car_height = 140;
            car_name = "casper";
            color = Color.DarkKhaki;
        }

        public int Width{
            get { return this.car_width; }
            set{
                if (value > 0)
                    this.car_width = value;
            }
        }

        public int Height {
            get { return this.car_height; }
            set{
                if (value > 0)
                    this.car_height = value;
            }

         }

        public Carpicture(int car_width, int car_height, string car_name, Color color)
        {
            this.car_width = car_width;
            this.car_height = car_height;
            this.car_name = car_name;
            this.color = color;

        }

        public int area
        {
            get { return car_width * car_height; }
        }


        public void MakeCar(){
            if(ProcessStarted != null){
                ProcessStarted(this, EventArgs.Empty);
            }
            step1();
            step2();
            step3();

            if(ProcessEnded != null){
                ProcessEnded(this, EventArgs.Empty);
            }
        }
        public void step1(){
            Console.WriteLine("Step #1");
        }
        public void step2()
        {
            Console.WriteLine("Step #2");
        }
        public void step3()
        {
            Console.WriteLine("Step #3");
        }
        public event EventHandler ProcessStarted;
        public event EventHandler ProcessEnded;

    }
}
