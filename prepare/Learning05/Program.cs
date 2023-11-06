using System;

class Program
{
    static void Main(string[] args)
    {
        //Square square = new Square("Green", 5.0);
        //Console.WriteLine($"Square Colour: {square.GetColour()}");
        //Console.WriteLine($"Square Area: {square.GetArea()} square units");
        List<Shape> shapes = new List<Shape>();
        
        Rectangle s1 = new Rectangle("Red", 4, 5);
        shapes.Add(s1);

        Circle s2 = new Circle("Yellow", 6);
        shapes.Add(s2);

        Square s3 = new Square("Blue", 3);
        shapes.Add(s3);

        foreach (Shape item in shapes)
        {
            string colour = item.GetColour();
            
            double area = item.GetArea();

            Console.WriteLine($"The {colour} shape has an area of {area}.");
        }
    }
}