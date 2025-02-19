namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task1 
            Func<double, double> areaCircle = radius => Math.PI * radius * radius;
            Func<double, double, double> areaRectangle = (width, lenght) => width * lenght;
            Func<double, double, double> areaTriangle = (baselenght, height) => 0.5 * baselenght * height;

            Console.WriteLine($"Circle Area (R=5);{areaCircle(5)}");
            Console.WriteLine($"Rectangle Area (w=6,h=8)={areaRectangle(6, 8)}");
            Console.WriteLine($"Triangle Area (b=4 ,h=3)={areaTriangle(7, 3)}");

        }
    }
}
