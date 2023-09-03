namespace SampleGeneric {
    internal class Program {
        static void Swap<T>(ref T a, ref T b) {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args) {
            var size = 5;

            // Instansiasi MyGenericClass dengan type integer
            // dan passing size untuk nilai pada constructor
            var intArray = new MyGenericClass<int>(size);

            // Menggunakan 'for' untuk set nilai dari index pertama 
            // sampai index terakhir dengan rumus 'nilai index dikali 5'
            for (int i = 0; i < size; i++) {
                intArray.SetItem(i, i * 5);
            }

            // Menggunakan 'for' untuk mengakses nilai
            for (int i = 0; i < size; i++) {
                Console.Write($"{intArray.GetItem(i)} ");
            }

            // Untuk menulis garis baru pada console
            Console.WriteLine();

            // Instansiasi MyGenericClass dengan type char
            // dan passing size untuk nilai pada constructor
            var charArray = new MyGenericClass<char>(size);

            // Menggunakan 'for' untuk set nilai dari index pertama 
            // sampai index terakhir dengan rumus '97 + nilai index'
            for (int i = 0;i < size; i++) {
                charArray.SetItem(i, (char)(i + 97));
            }

            // Menggunakan 'for' untuk mengakses nilai
            for (int i = 0;i<size; i++) {
                Console.Write($"{charArray.GetItem(i)} ");
            }
            Console.WriteLine();

            var a = 99;
            var b = 77;

            Console.WriteLine($"Sebelum di swap -> Nilai a = {a}, Nilai b = {b}");
            // Memanggil method Swap untuk menukar
            // nilai a dan b dengan type integer
            Swap<int>(ref a, ref b);
            Console.WriteLine($"Setelah di swap -> Nilai a = {a}, nilai b = {b}");
            
            Console.WriteLine();

            var x = 0.976f;
            var y = 1.234f;
            Console.WriteLine($"Sebelum di swap -> Nilai x = {x}, nilai y = {y}");
            // Memanggil method Swap untuk menukar
            // nilai x dan y dengan type float 
            Swap<float>(ref x, ref y);
            Console.WriteLine($"Setelah di swap -> Nilai x = {x}, nilai y = {y}");

            Console.ReadKey();
        }
    }
}