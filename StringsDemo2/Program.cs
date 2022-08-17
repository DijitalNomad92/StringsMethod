namespace StringsDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan pozitif bir tamsayı al
            // bu sayinın 1000'ler, 100'ler, 10'lar, 1'ler basamaklarını yazdır

            Console.WriteLine("Sayı gir: ");
            string sayi = Console.ReadLine();

            string[] basamakSayilari = new string[sayi.Length];

            for (int i=0; i <= sayi.Length -1; i++)
            {
                basamakSayilari[i] = sayi[i].ToString();
            }
        }
    }
}