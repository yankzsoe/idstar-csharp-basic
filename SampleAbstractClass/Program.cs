namespace SampleAbstractClass {
    internal class Program {
        static void Main(string[] args) {
            Hewan sapi = new Sapi();
            Hewan kucing = new Kucing();

            Console.WriteLine($"Hewan: {sapi.GetType().Name}. Jenis: {sapi.Jenis}. Suara {sapi.Suara}");
            Console.WriteLine($"Hewan: {kucing.GetType().Name}. Jenis: {kucing.Jenis}. Suara {kucing.Suara}");

            Console.ReadKey();
        }
    }

    public abstract class Hewan {
        public abstract string Jenis { get; }
        public abstract string Suara { get; }

    }

    public class Sapi : Hewan {
        public override string Jenis { get => "Herbivora"; }
        public override string Suara { get => "Mooo.."; }
    }

    public class Kucing : Hewan {
        // Properties dengan lambda
        public override string Jenis => "Karnivora";

        public override string Suara => "Meong..";
    }
}