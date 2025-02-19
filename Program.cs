using System.Runtime.CompilerServices;

namespace Task4
{
    internal class Program
    {
        public delegate void Method();
        static void Main(string[] args)
        {
            // Task 1
            Func<double, double> areaCircle = radius => Math.PI * radius * radius;
            Func<double, double, double> areaRectangle = (width, lenght) => width * lenght;
            Func<double, double, double> areaTriangle = (baselenght, height) => ( baselenght * height)/2;

            Console.WriteLine($"Circle Area (R=5);{areaCircle(5)}");
            Console.WriteLine($"Rectangle Area (w=6,h=8)={areaRectangle(6, 8)}");
            Console.WriteLine($"Triangle Area (b=4 ,h=3)={areaTriangle(7, 3)}");

            // Task 2

            Action multicatsDelegate = Method1;
            multicatsDelegate += Method2;
            multicatsDelegate += Method3;

            multicatsDelegate.Invoke();


            // Task 3   

            List<string> names = new List<string> { "Aqsin","Yaqub","Metin","Malik"};
            Func<string, bool> startsWithA = name => name.StartsWith("A");
            var filteredNames = names.Where(startsWithA);

            Console.WriteLine("\nNames starting with 'A':");
            foreach (var name in filteredNames)
            {
                Console.WriteLine(name);
            }









            // Task 4
            Func<int, int, int> add = (x, y) => x + y;
            Func<int ,int ,int> sub= (x, y) => x - y;
            Func<int, int, int> mult = (x, y) => x *y;
            Func<int, int, double> divide = (x, y) => y != 0 ? (double)x / y : throw new DivideByZeroException("Cannot divide by zero");
            Console.WriteLine($" Answer{ add(4,6)}");
            Console.WriteLine($" Answer{sub (9, 5)}");
            Console.WriteLine($" Answer{mult(4, 6)}");
            Console.WriteLine($" Answer{divide(9, 3)}");

        }
        public static void Method1()
        {
            Console.WriteLine("Method is true");
        }
        public static void Method2()
        {
            Console.WriteLine("Method is true");
        }
        public static void Method3()
        {
            Console.WriteLine("Method is true");
        }
    }
}
