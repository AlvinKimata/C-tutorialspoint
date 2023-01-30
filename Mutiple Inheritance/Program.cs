//C# does not implement multiple inheritance.
//One can use interfaces to implement multiple inheritance.
using System;

namespace InheritanceApplication
{
    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }

    //Base class PaintCost
    public interface PaintCost
    {
        int getCost(int area);
    }

    //Derived class.
    class Rectangle: Shape, PaintCost
    {
        public int getArea()
        {
            return (width * height);
        }

        public int getCost(int area)
        {
            return area * 70;
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            
            Rect.setWidth(5);
            Rect.setHeight(7);
            int area = Rect.getArea();

            //Print the area of the object.
            Console.WriteLine("Total area: {0}", area);
            Console.WriteLine("Total paint cost: ${0}", Rect.getCost(area));
        }
    }
}