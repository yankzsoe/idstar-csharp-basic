namespace SampleStringExtension {
    internal class Program {
        static void Main(string[] args) {
            string var1 = "ABCDE";
            Console.WriteLine($"string:{var1}");
            Console.WriteLine($"ascii:{var1.ToAscii()}");

            Console.ReadKey();
        }
    }
}