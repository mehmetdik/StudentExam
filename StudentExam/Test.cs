using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {


            islemler obj = new islemler(); //islemler classının objesini oluşturduk.


            Console.WriteLine("Kaç adet ogrenci:");//Kullanıcının kaç adet öğrenci bilgisini girmek istediğini sorduk.
            int Oadet = int.Parse(Console.ReadLine());//Kullanıcının konsola girdiği ifadeyi integer'a dönüştürdük ve integer bir değişkene atadık.


            string[] isim = new string[Oadet];//Öğrenci isimlerini tutması için bir dizi oluşturduk.Dizinin uzunuluğunu kullanıcının girmek istediği öğrenci bilgisi kadar yaptık.
            int[] Ono = new int[Oadet];       //Öğrenci numaralarını tutması için bir dizi oluşturduk. 
            int[] ders1 = new int[Oadet];      //Öğrencilarin  ders1 de aldıkları notları bir dizi de tutmak için bir dizi oluşturduk.
            int[] ders2 = new int[Oadet];       //Öğrencilarin  ders2 de aldıkları notları bir dizi de tutmak için bir dizi oluşturduk.
            int[] ders3 = new int[Oadet];       //Öğrencilarin  ders1 de aldıkları notları bir dizi de tutmak için bir dizi oluşturduk.



            obj.Bilgi(Oadet, isim, Ono, ders1, ders2, ders3);//Objesini oluşturduğumuz islemler classındaki öğrenci bilgilerini almak için oluşturduğumuz bilgi metoduna öğrenci bilgilerini tutması için diziler yolladık.
            Console.Clear();//Consoldaki yazıları siler
            string secim1 = null;
            do
            {


                Console.WriteLine("     Menu");
                Console.WriteLine("1-Girilen Bilgileri Giris Sirasina Gore Sirala");
                Console.WriteLine("2-Her Dersin Sinav Sonuc Ortalamasini Bul  ");
                Console.WriteLine("3-60'dan Kucuk Sinav SonuClarini Ve Bu Sonuclara Ait Ögrenci Numaralarini, Isimlerini Goruntule");
                Console.WriteLine("4-Ortalamanın Ustunde Not Alan Ogrenci Ve Notları");
                Console.WriteLine("5-60'dan Kucuk Sinav Sonuc Degerlerinin Sayisini Bul");
                Console.WriteLine("6-En Yuksek Sinav sonucu:");
                Console.WriteLine("7-En Dusuk Sinav Sonucu:");
                Console.WriteLine("8-Genel Sinav Sonuclarina  göre kucukten buyuge sirali olarak ogrenci numaralarini, isimlerini  ve sinav sonuclarini goruntule");
                Console.WriteLine("9-Öğrenci numaralarına göre küçükten büyüğe sıralı");
                Console.WriteLine("Secim:");
                int sec = int.Parse(Console.ReadLine()); //girilen ifadeyi integer'a çevirdik ve integer bir değişkene atadık.
                switch (sec)
                {
                    case 1:
                        Console.Clear();
                        obj.goruntule(Oadet, isim, Ono, ders1, ders2, ders3);//Daha önce objesini oluştumuş olduğumuz islemler classının goruntule metoduna öğrenci bilgilerini tutan dizileri yolladık.
                        break;

                    case 2:
                        int ort1 = obj.HerDersOrt(Oadet, ders1);//Daha önce objesini oluşturmuş olduğumuz işlemler clasının HerDersOrt metoduna ders1 dizisini yani ders1'den alnınan notları ,Öğrenci sayısını yolladık.
                        int ort2 = obj.HerDersOrt(Oadet, ders2);//Daha önce objesini oluşturmuş olduğumuz işlemler clasının HerDersOrt metoduna ders2 dizisini yani ders2'den alnınan notları ,Öğrenci sayısını yolladık.
                        int ort3 = obj.HerDersOrt(Oadet, ders3);//Daha önce objesini oluşturmuş olduğumuz işlemler clasının HerDersOrt metoduna ders3 dizisini yani ders3'den alnınan notları ,Öğrenci sayısını yolladık.
                        Console.Clear();
                        Console.WriteLine("1.Dersin Not ortalamasi:" + ort1);//Ders1'den alınan notların ortalamasını yazdırdık.
                        Console.WriteLine("2.Dersin Not ortalamsi:" + ort2);//Ders2'den alınan notların ortalamasını yazdırdık.
                        Console.WriteLine("3.Dersin Not ortalamasi:" + ort3);//Ders3'den alınan notların ortalamasını yazdırdık.
                        break;

                    case 3:
                        Console.Clear();
                        obj.Altmiskücük(Oadet, isim, Ono, ders1, ders2, ders3);//Daha önce objesini oluştumuş oldugumuz islemler clasının Altmiskücük metoduna öğrenci bilgilerini taşıyan dizileri gönderdik. 
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("1-Ders1");
                        Console.WriteLine("2-Ders2");
                        Console.WriteLine("3-Ders3");
                        Console.WriteLine("Secim:");
                        int secim = int.Parse(Console.ReadLine());//ifadeyi integer'a çevirdik.
                        Console.Clear();
                        obj.OrtUstu(secim, Oadet, Ono, ders1, ders2, ders3);//Daha önce objesini oluştumuş oldugumuz islemler clasının OrtUstu metoduna öğrenci bilgilerini taşıyan dizileri gönderdik,hangi dersi görmek istediğini debilten secim değişkenini de gönderdik. 
                        break;

                    case 5:
                        int sayac = obj.AltmıstanKücükSayi(Oadet, ders1);//Daha önce objesini oluştumuş oldugumuz islemler clasının AltmıstanKücükSayi metoduna öğrenci sayısısnı ve ders1'den aldıkları notları göderdik.Dönen sayıyı integer bir değere atadık .
                        int sayac2 = obj.AltmıstanKücükSayi(Oadet, ders2);//Daha önce objesini oluştumuş oldugumuz islemler clasının AltmıstanKücükSayi metoduna öğrenci sayısısnı ve ders2'den aldıkları notları göderdik.Dönen sayıyı integer bir değere atadık .
                        int sayac3 = obj.AltmıstanKücükSayi(Oadet, ders3);//Daha önce objesini oluştumuş oldugumuz islemler clasının AltmıstanKücükSayi metoduna öğrenci sayısısnı ve ders3'den aldıkları notları göderdik.Dönen sayıyı integer bir değere atadık .
                        Console.Clear();
                        Console.WriteLine("ders1 icin:" + sayac);//ders1 için kaçtane notun 60'dan küçük olduğunu yazdırdık.
                        Console.WriteLine("ders2 icin:" + sayac2);//ders2 için kaçtane notun 60'dan küçük olduğunu yazdırdık.
                        Console.WriteLine("ders3 icin:" + sayac3);//ders3 için kaçtane notun 60'dan küçük olduğunu yazdırdık.
                        break;

                    case 6:
                        int MaxSonuc = obj.MaxSonuc(Oadet, ders1);//Daha önce objesini oluşturmuş olduğumuz islemler clasının MaxSonuc metoduna öğrenci Nosunu ve ders1 notlarını tutan diziyi yolladık
                        int MaxSonuc2 = obj.MaxSonuc(Oadet, ders2);
                        int MaxSonuc3 = obj.MaxSonuc(Oadet, ders3);
                        Console.Clear();
                        Console.WriteLine("Ders1 İcin En Yüksek Not:" + MaxSonuc);//ders1 için alınan en yüksek notu yazdırdık
                        Console.WriteLine("Ders2 İcin En Yüksek Not:" + MaxSonuc2);
                        Console.WriteLine("Ders3 icin En Yüksek Not:" + MaxSonuc3);
                        break;

                    case 7:
                        int MinSonuc = obj.MinSonuc(Oadet, ders1);//Daha önce objesini oluşturmuş olduğumuz islemler clasının MinSonuc metoduna öğrenci Nosunu ve ders1 notlarını tutan diziyi yolladık
                        int MinSonuc2 = obj.MinSonuc(Oadet, ders2);
                        int MinSonuc3 = obj.MinSonuc(Oadet, ders3);
                        Console.Clear();
                        Console.WriteLine("Ders1 İcin En Düsük Not:" + MinSonuc);//Ders1 icin alınan en düşük notu yazdırdık.
                        Console.WriteLine("Ders2 İcin En Düsük Not:" + MinSonuc2);
                        Console.WriteLine("Ders3 İcin En Düsük Not:" + MinSonuc3);
                        break;

                    case 8:
                        Console.Clear();
                        string[] ortagoresırala = new string[Oadet];//return edilen bir dizi olduğu için onu bir diziye atamalıyız bu neden le bu diziyi oluşturduk.
                        ortagoresırala = obj.OrtSirala(Oadet, Ono, isim, ders1, ders2, ders3);//Öğrenci bilgilerini sıralanmış bir şekilde return edildi ve return edilen dizi oluşturduğumuz diziye atadık
                        for (int i = 0; i < Oadet; i++)
                        {
                            Console.WriteLine(ortagoresırala[i]);
                        }

                        break;

                    case 9:
                        Console.Clear();
                        string[] osirala = new string[Oadet];//return edilen bir dizi olduğu için onu bir diziye atamalıyız bu neden le bu diziyi oluşturduk
                        osirala = obj.OgrncSirala(Oadet, Ono, isim, ders1, ders2, ders3);
                        for (int i = 0; i < Oadet; i++)
                        {
                            Console.WriteLine(osirala[i]);

                        }

                        break;

                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Menuye dönmek için 'e' cikis icin 'h' basiniz");
                 secim1=Console.ReadLine();
            } while (secim1.Equals("e") || secim1.Equals("E"));
        }
    }
}
