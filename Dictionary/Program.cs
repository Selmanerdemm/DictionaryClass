using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Selman Erdem");
            myDictionary.Add(2,"Cemal Kaya");
            myDictionary.Add(3,"Furkan Pala");
            myDictionary.Add(4, "Mustafa Dümen");
            myDictionary.Add(5,"Filiz Akın");
            

            myDictionary.Display();



            //var kullanicilar = new Dictionary<int, string>();

            //kullanicilar.Add(1,"Selman Erdem");
            //kullanicilar.Add(2, "Cemal Kaya");
            //kullanicilar.Add(3,"Furkan Pala");
            //kullanicilar.Add(4,"Mustafa Dümen");

            //foreach (KeyValuePair<int,string> kullanici in kullanicilar)

            //{
            //    Console.WriteLine("ID: "+kullanici.Key + " " + "Full Name: "+ kullanici.Value);
                
            //}

            //string yeniKullanici = "Filiz Şahap";
            //bool varmi = kullanicilar.TryGetValue(0, out yeniKullanici);

            //if (varmi)
            //{
            //    Console.WriteLine("Bu Id de bir kullanıcı mevcuttur.");
            //}
            //else
            //{
            //    kullanicilar.Add(0,yeniKullanici);
            //    Console.WriteLine("Ekleme işlemi başarıyla gerçekleşti"+);
                
            //}
        }
    }
}
