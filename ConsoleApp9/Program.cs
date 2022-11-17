using System;
using System.Collections.Generic;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            int qaliq, cem = 0;
            int netice = 0;
            Console.Write("Eded : ");
            int eded = Convert.ToInt32(Console.ReadLine());
            while (eded > 10)
            {
                qaliq = eded % 10;
                eded = (eded - (eded % 10)) / 10;

                cem += qaliq;
            }
            netice = cem + eded;
            Console.WriteLine("Girdiyiniz Sayinin Reqemleri Cemi : " + netice);
            #endregion



            #region Task2
            //Console.WriteLine("Eded daxil edin:");
            //int eded = Convert.ToInt32(Console.ReadLine());
            //int qaliq = eded%7;
            //int netice=0;
            //if (qaliq==0)
            //{
            //    Console.WriteLine("Eded 7e bolunur");
            //}
            //else
            //{
            //    if (qaliq>3)
            //    {
            //       netice= eded + (7 - qaliq);
            //        Console.WriteLine(netice);
            //    }
            //    else
            //    {
            //        netice = eded - qaliq;
            //        Console.WriteLine(netice);
            //  }
            //}
            #endregion
        }
    }
}

