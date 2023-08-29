namespace SampleRecord {
    internal class Program {
        public record Point(int x, int y);
        public record Person {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        static void Main(string[] args) {
            /*
            Point point1 = new Point(5, 10);
            Point point2 = point1 with { x = 3 };

            Console.WriteLine($"Point 1: X={point1.x}, Y={point1.y} ");
            Console.WriteLine($"Point 2: X={point2.x}, Y={point2.y} ");
            */

            Person person1 = new Person { FirstName = "Jhon", LastName = "Doe" };
            Person person2 = new Person { FirstName = "Jhon", LastName = "Wick" };
            Console.WriteLine($"Person 1: {person1.FirstName} {person1.LastName}");
            Console.WriteLine($"Person 2: {person2.FirstName} {person2.LastName}");
            Console.ReadKey();
        }
    }
}