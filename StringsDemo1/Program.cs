namespace StringsDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  A123456-7
            // A: bireysel, B: kurumsal
            // 123456: bina no
            // 7: daire no


            // kullanıcıdan abone no alacan
            // abone no'ya gore bireysel / kurumsal oldugu,
            // bina no,
            // daire no ekrana yazdır

            Console.WriteLine("A123456-7");

            Console.Write("Abone no gir: ");
            string abNo = Console.ReadLine();

            string aboneTipi;
            string binaNo;
            string daireNo;

            //if (abNo.Substring(0, 1) == "A") ;
            //if (abNo[0] == 'A');
            if (abNo.StartsWith("A"))

                aboneTipi = "Bireysel";

            else

                aboneTipi = "Kurumsal";

            // binaNo = abNo.Substring(1, 6);
            // daireNo = abNo.Substring(8);
            string binaVeDaireNo = abNo.Substring(1); //123456-7 bu sonuc kaldı A yı kaldırdık
            int tireIndex = binaVeDaireNo.IndexOf("-");
            binaNo = binaVeDaireNo.Substring(0, tireIndex);
            daireNo = binaVeDaireNo.Substring(tireIndex + 1);

            //string[] binaDaire = binaVeDaireNo.Split('-');
            //binaNo = binaDaire[0];
            //daireNo = binaDaire[1];   bu şekilde de sonuca ulaşabiliriz

            Console.WriteLine(aboneTipi + " - " + binaNo + " - " + daireNo);
            
        }
    }
}