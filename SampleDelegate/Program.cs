namespace SampleDelegate {
    internal class Program {

        static void Main(string[] args) {
            var var1 = 10;
            var var2 = 5;

            // mengintansiasi class CalculatorOperations 
            var calcOpr = new CalculatorOperations();

            // menginstansiasi delegate
            // dan memberikan paramter method "Add"
            var operationAdd = new Operation(calcOpr.Add);
            
            // cara ke 1 untuk menggunakan delegate
            var result1 = operationAdd(var1, var2);

            // cara ke 2 untuk menggunakan delegate
            // ini cara lebih aman karena ada pengecekan null terlebih dahulu
            var result2 = operationAdd?.Invoke(var1, var2);

            Console.WriteLine($"Addition {var1} and {var2} = {result1}");
            Console.WriteLine($"Addition {var1} and {var2} = {result2}");

            // menginstansiasi delegate sebagai array
            // dan memberikan paramter method yang ada di CalculatorOperations
            var operationsCalc = new Operation[4] { calcOpr.Add, calcOpr.Multiply, calcOpr.Substract, calcOpr.Divide };

            for ( int i = 0; i < operationsCalc.Length; i++) {
                Console.WriteLine($"Operation {operationsCalc[i]?.Method.Name} {var1} with {var2} = {operationsCalc[i]?.Invoke(var1, var2)}");
            }

            Console.ReadKey();
        }
    }

    // mendeklarasikan delegate dengan nama "Operation"
    // yang menerima 2 paramter integer dan membalikan nilai integer
    public delegate int Operation(int x, int y);
}