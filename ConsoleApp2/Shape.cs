namespace ConsoleApp2
{
    public class Shape
    {
        protected int width;
        protected int height;
        public void setWidth(int w){
            width = w;
        }

        public void setHeight(int h){
            height = h;
        }
    }


    class Rectangle: Shape{
        public int getArea(){
            return (width * height);
        }
    }
}