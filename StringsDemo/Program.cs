
// Cümle içerisinde kelime parçalamak ve bulmak

string cumle = "Merhaba dünyalı, ben dostum.";
Console.WriteLine(cumle);
Console.Write("Aranacak kelime: ");

string[] kelimeler = cumle.ToLower().Split(' ', ',', '.');  // burda boşluk,virgul ve noktaya gore parçaladı kelimeleri ve ., kalktı ortadan

string kelime = Console.ReadLine();

//if (kelimeler.Contains(kelime))

if (kelime.Length == 0)   // if (kelime == "")  // if(string.IsNullOrWhiteSpace(kelime)); - boşlıkraı trimler ve null kontrol eder
{
    Console.WriteLine("Krlime giriniz: ");
}
else
{   
    if (kelimeler.Contains(kelime.ToLower()))  // ToLower ile kuçuk büyük harf duyarlılıgıg ordatan kaldırıyoruz
    Console.WriteLine("Aradığınız kelimeyi buldunuz");
   else
   Console.WriteLine("Aradıgınız kelimeyi bulmamadınız");
}



