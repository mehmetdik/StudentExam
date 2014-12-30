using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class islemler
    {
        public void Bilgi(int adet, string[] isim, int[] no, int[] ders1, int[] ders2, int[] ders3)//Öğrenci bilgilerini alan metod
        {
            Boolean don = false;
            for (int i = 0; i < adet; i++)
            {
                do
                {
                    try
                    {


                        Console.Clear();
                        Console.WriteLine((i + 1) + ".ogrenci");
                        Console.WriteLine();
                        Console.WriteLine("No:");
                        no[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("isim:");
                        isim[i] = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Ders 1(sınav):");
                        ders1[i] = int.Parse(Console.ReadLine());
                        if (ders1[i]<0 || ders1[i]>100)
                        {
                            don = true;
                            Console.WriteLine("0 ile 100 arasında bir sayi giriniz!Başa dönmek için bir tuşa basınız.");
                            Console.ReadLine();
                            break;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Ders 2(sınav):");
                        ders2[i] = int.Parse(Console.ReadLine());
                        if (ders2[i] < 0 || ders2[i] > 100)
                        {
                            don = true;
                            Console.WriteLine("0 ile 100 arasında bir sayi giriniz!Başa dönmek için bir tuşa basınız.");
                            Console.ReadLine();
                            break;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Ders 3(sınav):");
                        ders3[i] = int.Parse(Console.ReadLine());
                        if (ders3[i] < 0 || ders3[i] > 100)
                        {
                            don = true;
                            Console.WriteLine("0 ile 100 arasında bir sayi giriniz!Başa dönmek için bir tuşa basınız.");
                            Console.ReadLine();
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Hata Lütfen bir tusa basin!");
                        Console.ReadLine();
                        don = true;
                    }
                } while (don);

            }

        }



        public void goruntule(int adet, string[] isim, int[] no, int[] ders1, int[] ders2, int[] ders3)//Öğrenci bilgilerini görüntüleyen method
        {

            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine("No:" + no[i] + "  isim:" + isim[i] + "  ders1:" + ders1[i] + "  ders2:" + ders2[i] + "  ders3:" + ders3[i]);//sırayla öğrencilerin bilgilerini yazdırır.

                Console.WriteLine();

            }

        }



        public int HerDersOrt(int adet, int[] ders)//Dersin ortalamasını bulun return eden method
        {
            int Total = 0;
            for (int i = 0; i < adet; i++)
            {
                Total = Total + ders[i];//Derslerden alınan notları topladık ve totale atadık.

            }
            int ort = Total / adet;//ortalamayı buldu


            return ort;
        }



        public void Altmiskücük(int adet, string[] isim, int[] Ono, int[] ders1, int[] ders2, int[] ders3)//Sınav notu 60'dan küçük olan kişilerin sayısını bulan method
        {
            int sayac = 0;//Altmıştan küçük notların sayılarını bulmak için tanımladık
            for (int i = 0; i < adet; i++)
            {
                if (ders1[i] < 60)
                {
                    sayac++;
                    Console.WriteLine("1.Ders(sınav sonucu):" + ders1[i]);
                }
                if (ders2[i] < 60)
                {
                    sayac++;
                    Console.WriteLine("2.Ders(sınac sonucu):" + ders2[i]);
                }
                if (ders3[i] < 60)
                {
                    sayac++;
                    Console.WriteLine("3.Ders(sınav sonucu):" + ders3[i]);
                }
                if (sayac > 0)
                {
                    Console.WriteLine("isim:" + isim[i]);
                    Console.WriteLine("No:" + Ono[i]);
                    sayac = 0;
                }

            }
        }


        public void OrtUstu(int secim, int adet, int[] No, int[] ders1, int[] ders2, int[] ders3)//Ortalamanın Ustunde Not Alan Ogrenci Ve Notları 
        {

            int Total1 = 0, Total2 = 0, Total3 = 0;
            for (int i = 0; i < adet; i++)//derslerde alınan notların toplamını bulur
            {
                Total1 = Total1 + ders1[i];
                Total2 = Total2 + ders2[i];
                Total3 = Total3 + ders3[i];
            }
            int ort1 = Total1 / adet;
            int ort2 = Total2 / adet;//ortalamaları bulur
            int ort3 = Total3 / adet;

            if (secim == 1)
            {
                for (int i = 0; i < adet; i++)
                {
                    if (ders1[i] > ort1)
                    {
                        Console.WriteLine("No:" + No[i] + " Not:" + ders1[i]);
                    }
                }
            }
            else if (secim == 2)
            {
                for (int i = 0; i < adet; i++)
                {
                    if (ders2[i] > ort1)
                    {
                        Console.WriteLine("No:" + No[i] + " Not:" + ders2[i]);
                    }
                }

            }
            else if (secim == 3)
            {
                for (int i = 0; i < adet; i++)
                {
                    if (ders3[i] > ort1)
                    {
                        Console.WriteLine("No:" + No[i] + " Not:" + ders3[i]);
                    }
                }

            }


        }

        public int AltmıstanKücükSayi(int adet, int[] ders)//Altmıstan küçük notların sayısını bulur.
        {
            int sayac = 0;

            for (int i = 0; i < adet; i++)
            {
                if (ders[i] < 60)
                {
                    sayac++;

                }

            }


            return sayac;
        }


        public int MaxSonuc(int Adet, int[] ders)//dersde alınan en yüksek notu dönderen method
        {
            int MaxSonuc = ders[0];
            for (int i = 0; i < Adet; i++)
            {
                if (MaxSonuc < ders[i])
                {
                    MaxSonuc = ders[i];
                }


            }
            return MaxSonuc;


        }


        public int MinSonuc(int Adet, int[] ders)//dersde alınan en düşük notu dönderen method
        {
            int MinSonuc = ders[0];
            for (int i = 0; i < Adet; i++)
            {
                if (ders[i] < MinSonuc)
                {
                    MinSonuc = ders[i];
                }

            }
            return MinSonuc;

        }


        public string[] OrtSirala(int Adet, int[] No, string[] isim, int[] ders1, int[] ders2, int[] ders3)//Genel Sinav Sonuclarina  göre kucukten buyuge sirali olarak ogrenci numaralarini, isimlerini  ve sinav sonuclarini goruntule
        {
            int[] sonuc = new int[Adet];
            int gecici = 0;
            string gecici2 = null;
            string[] x = new string[Adet];
            for (int i = 0; i < Adet; i++)
            {
                sonuc[i] = (ders1[i] + ders2[i] + ders3[i]) / 3;//derslerin ortalamasını bulur ve sonuc dizisine atar.
            }

            for (int i = 1; i < Adet; i++)
            {
                for (int j = 0; j < Adet - i; j++)//Bouble Short ile sıraladık
                {
                    if (sonuc[j] > sonuc[j + 1])
                    {
                        gecici = No[j];
                        No[j] = No[j + 1];
                        No[j + 1] = gecici;

                        gecici2 = isim[j];
                        isim[j] = isim[j + 1];
                        isim[j + 1] = gecici2;

                        gecici = ders1[j];
                        ders1[j] = ders1[j + 1];
                        ders1[j + 1] = gecici;

                        gecici = ders2[j];
                        ders2[j] = ders2[j + 1];
                        ders2[j + 1] = gecici;

                        gecici = ders3[j];
                        ders3[j] = ders3[j + 1];
                        ders3[j + 1] = gecici;

                    }
                }
            }
            for (int k = 0; k < Adet; k++)
            {
                string a = "No:" + No[k] + "  isim:" + isim[k] + "  ders1:" + ders1[k] + "  ders2:" + ders2[k] + "  ders3:" + ders3[k];//sıralanmış bilgileri a  stringine atadık.
                x[k] = a;//a stringini x dizisine atadık
            }
            return x;
        }






        public string[] OgrncSirala(int Adet, int[] No, string[] isim, int[] ders1, int[] ders2, int[] ders3)//Öğrenci numaralarına göre küçükten büyüğe sıralı
        {
            int gecici = 0;
            string gecici2 = null;
            string[] x = new string[Adet];

            for (int i = 1; i < Adet; i++)
            {
                for (int j = 0; j < Adet - i; j++)//Bubble Shor ile sıraladık
                {
                    if (No[j] > No[j + 1])
                    {
                        gecici = No[j];
                        No[j] = No[j + 1];
                        No[j + 1] = gecici;

                        gecici2 = isim[j];
                        isim[j] = isim[j + 1];
                        isim[j + 1] = gecici2;

                        gecici = ders1[j];
                        ders1[j] = ders1[j + 1];
                        ders1[j + 1] = gecici;

                        gecici = ders2[j];
                        ders2[j] = ders2[j + 1];
                        ders2[j + 1] = gecici;

                        gecici = ders3[j];
                        ders3[j] = ders3[j + 1];
                        ders3[j + 1] = gecici;

                    }
                }


            }
            for (int k = 0; k < Adet; k++)
            {
                string a = "No:" + No[k] + "  isim:" + isim[k] + "  ders1:" + ders1[k] + "  ders2:" + ders2[k] + "  ders3:" + ders3[k];
                x[k] = a;
            }

            return x;

        }


    }
}
