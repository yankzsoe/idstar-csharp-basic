namespace SampleStringExtension {
    public static class StringExtensions {
        // Sebuah method ToAscii dengan parameter 'this' berupa string
        // maka method ToAscii ini akan muncul di tipe data string
        public static string ToAscii(this string str) {
            if (string.IsNullOrWhiteSpace(str))
                return string.Empty;

            var result = string.Empty;
            foreach (char c in str) {
                result += Convert.ToInt32(c);
            }
            return result;
        }
    }
}
