using System;
namespace BoxApplication
{
    class Box
    {
         private double length;   
         private double breadth;  
         private double height;
         private double volume; 
  
        public void SetLength(double length)
        {
            this.length = length;

        }
        public void SetBreadth(double breadth)
        {
            this.breadth = breadth;

        }
        public void SetHeight(double height)
        {
            this.height = height;

        }

        public double CalVolume()
        {
            this.volume=(this.height * this.length * this.breadth);

            return this.volume;
        }





    }


    class BoxSet
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();   
            Box Box2 = new Box();  
               
           

            Box1.SetHeight(15.0);
            Box1.SetLength(16.0);
            Box1.SetBreadth(17.0);


            Box2.SetHeight(11.0);
            Box2.SetLength(13.0);
            Box2.SetBreadth(17.0);




            Console.WriteLine("Box 1 Volume : "+Box1.CalVolume());



            Console.WriteLine("Box 2 Volume : " + Box2.CalVolume());
            Console.ReadKey();
        }
    }
}