using System;
namespace ConsoleApp2
{
     class Box
    {
        private double length;
        private double breadth;
        private double height;

        public double getVolume(){
            return length * breadth * height;
        }

        public void setLength(double len){
            length = len;
        }
        public void setBreadth(double bre){
            breadth = bre;
        }

        public void setHeight(double hei){
            height = hei;
        }

        public static Box operator+ (Box b, Box c){
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;

        }
    }
}