namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city1 = "Ankara";

            Console.WriteLine(city1[0]); // A yazdırır

            foreach (var city in city1)
            {
                Console.WriteLine(city); // Ankarayı alt alta
            }


            string city2 = "İstanbul";
            string result1 = city1 + " " + city2;  // cancatenation: Ankara İstanbul sonuç
            Console.WriteLine(result1);

            string result2 = string.Format("{0} {1}", city1, city2); // Ankara İstanbul
            string result3 = string.Format($"{city1} { city2}"); // Ankara İstanbul

            #region string methods

            string sentence = "My name is Çağıl Alsaç";
            int sentenceLength = sentence.Length; // 22
            sentence = sentence.Replace("Çağıl", "Leo"); // replace Alsaç adı Leo olarak değiştirdi ve sentence'i guncelledi
            //My name is Leo Alsaç

            if (sentence.EndsWith("ç"))
            {
                Console.WriteLine("sentence ends with ç");
            }
            else
            {
                Console.WriteLine("sentence doesn't ends with ç");
            }
            if (sentence.StartsWith("Ali"))
            {
                Console.WriteLine("Ali ile başlıyor");
            }
            else
            {
                Console.WriteLine("Ali ile başlamıyor");
            }
            if (sentence.Contains("İs"))
            {
                Console.WriteLine("is var");
            }
            else
            {
                Console.WriteLine("is yok");
            }
            //My name is Leo Alsaç

            int indexOfIs = sentence.IndexOf("is"); // 8 doner is başladıgı char sırası
            int indexOfIs1 = sentence.IndexOf("İs"); // -1 doner olmadğı harakter ise hep -1 doner

            int İndexOfSpace = sentence.IndexOf(' '); //2 donecek ilk boşluk saırası

            int lastIndexOfSpace = sentence.IndexOf(" "); //14 son kelimenin onundeki index Leo onundeki index 

            //sentence = "Hello! " + sentence;
            sentence = sentence.Insert(0, "Hello! ");
            // Hello! My name is Leo Alsaç

            string subSentence = sentence.Substring(18, 3); // Leo yazar 18 indexten sonraki 3 karakter

            subSentence = sentence.Substring(7); // My name is Leo Alsaç - burda 7 indexten sonraki hepsini getirir

            Console.WriteLine(sentence.ToLower() + " - " + sentence.ToUpper()); // cumleyi kucuk ve buyuk karaktere çevirir

            Console.WriteLine(sentence.Remove(5, 1));  // burda 5 index 1 karakter sil

            sentence = sentence.Remove(0, 7);
            Console.WriteLine(sentence);
            // My name is Leo Alsaç

            string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);  // kelimeleri alt alta yazdırır
            }
            Console.WriteLine(words[3]);  // Leo

            string test1 = "Test1";
            string test2 = "Test2";
            if (test1 == test2)
            {
                Console.WriteLine("Test1 = Test2");
            }
            else
            {
                Console.WriteLine("Test1 != Test2");
            }
            if (test1.Equals(test2))
            {
                Console.WriteLine("Test1 = test2");
            }
            else
            {
                Console.WriteLine("Test1 != Test2");
            }

            // escape sequences

            string ad = "\"Çağıl\""; // "Çağıl"  tırnak içinde saklamak istesek

            Console.WriteLine(ad);

            char c = '\'';
            Console.WriteLine(c);  // karakteri gireceksek

            Console.WriteLine("Çağıl\nAlsaç");  // n : new line  yeni satıra geçer

            Console.WriteLine("Çağıl\tAlsaç");  // t: tab arada boşluk bırakıyor

            Console.WriteLine("Çağıl\n\rAlsaç");  // r: carriage return alta geç ve en basa gel

            string dosyaYolu = "C:\\çağıl\\8137\\notlar.txt"; //  \: back slash

            dosyaYolu = @"C:\çagıl\8137\notlar.txt";  // bu da @ ekleyerek tekli kuulanabiliriz

            Console.WriteLine(dosyaYolu);

            string isim = " Çağıl Alsaç ";
            string gosterim = "\"" + isim.Trim() + "\"";  // " Çağıl Alsaç "   trim başta ve sonda boşluk siler
            Console.WriteLine(gosterim);


            // Çağıl Alsaç En Büyük

            string cumlecik = "Çağıl Alsaç En   Büyük";
            cumlecik = cumlecik.Replace(" ", "");  // aradaki boşlukları sileriz
            Console.WriteLine(cumlecik);

            #endregion
        }
    }
}