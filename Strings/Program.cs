namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string city = "Ankara";
            //string city2 = "İstanbul";

            //Console.WriteLine(String.Format("{0} {1}", city, city2));

            string sentence = "test test2 test3";

            var result = sentence.Length; // karakter uzunluğu

            var result2 = sentence.Clone(); // klonlar

            bool result3 = sentence.EndsWith("Ğ");
            bool result4 = sentence.StartsWith("Te");

            var result5 = sentence.IndexOf("name"); // name i arar

            var result6 = sentence.IndexOf(' '); // ilk bulduğunu kabul eder

            var result7 = sentence.LastIndexOf(" "); // sondan başlar

            var result8 = sentence.Insert(0, "Hello, "); // cümleye ekleme yapar

            var result9 = sentence.Substring(3, 4); // 3 karakterden itibaran 4 tane al

            var result10 = sentence.ToLower(); // karakterleri küçüğe çevirir

            var result11 = sentence.ToUpper();

            var result12 = sentence.Replace(" ", "-");

            var result13 = sentence.Remove(0, 1); // 0 dan itibaren 1 tane kaldıır.
            
        }
    }
}