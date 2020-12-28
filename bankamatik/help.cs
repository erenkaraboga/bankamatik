using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankamatik
{
    class help
    {
        #region Butçe fieldı oluşturduk.
        private static int Butce;
        #endregion

        #region  Yapıcı metod ile bütçeyi en başta sıfıra eşitledik
        static help()
        {
            Butce = 0;
        }
        #endregion

        #region Bütçeyi Kapsulledik 
        public int _butce
        {
            get
            {

                return Butce;
            }
            set
            {

                Butce = value;

            }

        }
        #endregion

        #region Methodlarımız
        public static void menuGoster()
        {
            Console.WriteLine("---------Hoşgeldiniz---------");
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz");
            Console.WriteLine("1-Tutar Görüntüle\n2-Tutar Yatır\n3-Tutar Çek\n4-Çıkış");

        }

        public static void secimYap(int a)
        {
            if (a == 1)
            {
                Console.WriteLine("Bütçeniz {0}TL", Butce);


            }
            if (a == 2)
            {
                Console.WriteLine("Eklemek İstediğiniz Tutarı Giriniz");
                Butce += Paraekle();

            }

            if (a == 3)
            {
                Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz");

                int c = Paracek();
                if (Butce >= c)
                {
                    Butce -= c;
                }
                else
                {
                    Console.WriteLine("Limit Yok");
                    Console.WriteLine("Eksiye Girmek İster Misiniz? 1/2");
                    int s2 = int.Parse(Console.ReadLine());
                    if (s2 == 1)
                    {
                        Butce -= c;

                    }
                    else
                    {
                        return;

                    }
                }
            }

            if (a == 4)
            {
                Console.WriteLine("Çıkış Yapılıyor");
            }

        }
        private static int Paraekle()
        {
            int x = int.Parse(Console.ReadLine());
            return x;
        }
        private static int Paracek()
        {
            int x = int.Parse(Console.ReadLine());
            return x;
        }

        #endregion

    }
}
