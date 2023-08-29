namespace CSharpBasic {
    internal class Program {
        static void Main(string[] args) {
            Person person = new Person();
            person.Name = "Test";
            person.Age = 30;
            person.SayHello();

            Console.ReadKey();
        }
    }
}