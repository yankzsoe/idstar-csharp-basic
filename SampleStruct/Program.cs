namespace SampleStruct {
    internal class Program {
        struct StructVector {
            double X { get; set; }
            private double Y { get; set; }

            public StructVector(double x, double y) {
                X = x;
                Y = y;
            }

            private double getLength() {
                return Math.Sqrt(X * X + Y * Y);
            }

            public void ShowLength() {
                Console.WriteLine($"Length: {getLength()}");
            }
        }
        static void Main(string[] args) {
            StructVector vector = new StructVector(2, 3);
            vector.ShowLength();


            Console.ReadKey();
        }
    }
}