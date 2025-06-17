using System;
using System.Xml.Linq;

namespace HelloWord
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen aşağıdakı bilgileri giriniz :\n"); // \n bir alt satıra in demek
            Console.Write("T.C. Kimlik Numarasını :"); //consale Write ekara yazdır ama alt satıra inme
            string Tc = Console.ReadLine();
            if (!Tc.All(char.IsDigit) || Tc.Length != 11) //burda da tc rakam dısında bır sey girmemesi veya
                                                          //11 rakamdan olustugunu belirtim
            {
                Console.WriteLine("Tc kimlik numarası rakamdan olusur veya eksik girdiniz");
                return; // burda eger ki tc de harf veya eksik girilmişse uygulamayı durdur
            }
            Console.Write("isim giriniz :");
            string name = Console.ReadLine();
            if(string.IsNullOrEmpty(name) || kontrol(name) == true) // burda isimin rakam yazılması veya
                                                                     // bos gecilmemesi icin kontrol ekledim
            {
                Console.WriteLine("Boş gecilemez isim sadece harften olusur.");
                return;// girse uygulama return ile sonlandırılıyor
            }
            Console.Write("Soyisim giriniz :");
            string soyad = Console.ReadLine();
            if (string.IsNullOrEmpty(soyad) || kontrol(soyad) == true) //burda soyisimin rakam yazılması veya bos gecilmemesi
                                                                        //icin kontrol ekledim
            {
                Console.WriteLine("Boş gecilemez Soyisim sadece harften olusur :");
                return;// girse uygulama return ile sonlandırılıyor
            }
            Console.Write("Telefon numarası giriniz :");
            string numara = Console.ReadLine();
            if (!numara.All(char.IsDigit) || numara.Length != 10) //burda da numaranoın rakam dısında bır sey
                                                                  //girmemesi ve 10 rakamdan olustugunu belirtim
            {
                Console.WriteLine("Telefon numarası rakamdan olusur veya  eksik girdiniz");
                return;// girse uygulama return ile sonlandırılıyor
            }
            Console.Write("Yasınızı giriniz :");
            string yas = Console.ReadLine();
            if (!yas.All(char.IsDigit)) // yaşın rakam dısından bır harf veya
                                        // ozel kararekter girmemesi kontrolu yaptım
            {
                Console.WriteLine("Yaş rakamdan olusur :");
                return; // girse uygulama return ile sonlandırılıyor
            }
            Console.Write("İlk ürünün fiyatını giriniz :");
            string ilkUrun = Console.ReadLine();
            if (!ilkUrun.All(char.IsDigit))// ilk ürün fitayatının rakam dısından bır harf veya
                                           // ozel kararekter girmemesi kontrolu yaptım
            {
                Console.WriteLine("ilk ürünün fiyatı rakamdan olusur :");
                return;// girse uygulama return ile sonlandırılıyor
            }
            Console.Write("ikinci ürünün fiyatını giriniz :");
            string ikinciUrun = Console.ReadLine();
            if (!ikinciUrun.All(char.IsDigit)) //ikinci ürün fitayatının rakam dısından bır harf veya
                                               //ozel kararekter girmemesi kontrolu yaptım
            {
                Console.WriteLine("ikinci ürünün fiyatı rakamdan olusur :");
                return;// girse uygulama return ile sonlandırılıyor
            }
            double toplam = int.Parse(ilkUrun) + int.Parse(ikinciUrun);
            double yuzde = toplam * 0.10;
            Console.WriteLine($"\n{Tc} Tc numaralı {name} isimli kişi icin kayıt olusmustur.");
            Console.WriteLine($"{numara} Telefon numarasına bildirim mesaji göndermiştir.");
            Console.WriteLine($"{toplam} Toplam harcama karşılıgı kazanılan %10 patika puan miktari -> {yuzde} TL dir.");
        }
       static bool kontrol(string text) // metot yazdım  string degişkeninin icindeki degeri bakıp
                                         // icinde harf veya özel karekter varmı varsa true yoksa false donecek.
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr))
                        return false;
            }
            return true;
        }
    }
}
