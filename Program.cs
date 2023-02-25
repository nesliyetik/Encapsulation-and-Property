using System;

namespace encapsulation

{
    class Program
    {
        static void Main (string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yilmaz";
            ogrenci.OgrenciNo = 1234;
            ogrenci.Sinif = 5;
            ogrenci.OgrenciBilgileriniGetir();
            
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Leyla","Yıldız", 1313, 1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();


            //encapsulation: bir nesnenin bazı özelliklerini veya işlevlerini metotlarını diğer classlardan ve diğer nesnelerden korumak anlamına gelir.
            //property'ler yardımıyla encapsulation'ı kullanarak sınıf üyelerini/field'larını kapatabiliriz/ onların değişimini engelleyebiliriz ya da koruyabiliriz.
            //property'ler get ve set'lerden oluşur.
        }
    }
    
    class Ogrenci
    {
        private string isim;

        private string soyisim;

        private int ogrenciNo;

        private int sinif;

        public string Isim
        
        {
            get { return isim; }
            set { isim = value; }
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }

        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }

        public int Sinif 
        { 
            get => sinif; 
            set
            {
                if(value <= 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir!");
                    sinif=1;
                }
                else
                    sinif = value;
            }

        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif) 
        
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci() {}
        
        public void OgrenciBilgileriniGetir()

        {
            Console.WriteLine("****Öğrenci Bilgileri****");
            Console.WriteLine("Öğrenci Adı : {0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı : {0}", this.Soyisim);
            Console.WriteLine("Öğrenci No : {0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı : {0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif +1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif -1;
        }

    }

}
