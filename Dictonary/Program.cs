using System;
using System.Collections.Generic;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> ogrenciler = new List<string>();
            ogrenciler.Add("Çağlar");
            ogrenciler.Add("Yaren");
            ogrenciler.Add("Aslı");
            ogrenciler.Add("Cihan");
            ogrenciler.Add("Engin");
            Console.WriteLine(ogrenciler.Count);


            MyDictonary<string> ogrenciler1 = new MyDictonary<string>();
            ogrenciler1.Add("İLHAMİ");
            ogrenciler1.Add("Yasin");
            ogrenciler1.Add("Yunus");
            ogrenciler1.Add("Berkay");
            ogrenciler1.Add("Talha");
            ogrenciler1.Add("Eyüp");
            Console.WriteLine(ogrenciler1.Count);
       
           
        }
    }
}
