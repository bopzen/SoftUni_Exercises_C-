namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape rect = new Rectangle(10, 10);
            Shape circ = new Circle(10);
            Console.WriteLine(rect.CalculatePerimeter());
            Console.WriteLine(rect.CalculateArea());
            Console.WriteLine(rect.Draw());
            Console.WriteLine(circ.CalculatePerimeter());
            Console.WriteLine(rect.CalculateArea());
            Console.WriteLine(rect.Draw());
        }
    }
}