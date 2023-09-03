namespace SampleGeneric {
    // Class generic selalu ditandai dengan tanda '<T>' 
    internal class MyGenericClass<T> {
        // Mendeklarasi sebuah array dengan tipe generic
        private readonly T[] array;


        // Constructor untuk inisialisasi length dari array generic
        public MyGenericClass(int size) {
            array = new T[size];
        }

        // Method GetItem untuk mengambil value 
        // berdasarkan index yang ditentukan dalam parameter
        public T GetItem(int index) {
            return array[index];
        }

        // Method SetItem untuk memberikan value 
        // berdasarkan index yang ditentukan dalam parameter
        public void SetItem(int index, T value) {
            array[index] = value;
        }
    }
}
