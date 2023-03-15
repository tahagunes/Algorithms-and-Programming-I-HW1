using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, u2n, u2nn, downpartsqrtnumber, downpartsqrtnumber1;
            double R1, R2, stopIT, stopIT2,stopIT3, uppart, uppartt, downpart, downpart1, d2nn, d1n, result, d2n, d1nn;
            string operation;
            stopIT = 0;
            stopIT2 = 0;
            stopIT3 = 0;
            number = 0;            
            u2n = 0;
            d1n = Math.Pow(2, 3);//kontrol et patlayabilir
            d1nn = Math.Pow(2, 4);
            u2nn = 50;
            R1 = 0;
            R2 = 0;
            downpartsqrtnumber = 1000;
            downpartsqrtnumber1 = 998;

            /*
            number kullanıcıdan alınan
            u2n ve u2nn +lıların max kısmındaki kullanıcıdan alınmayan sayı
            d1n ve d1nn 2üssü 3 veya 4 olan sayı
            downpartsqrtnumber ve downpartsqrtnumber1 kökün içindeki sayı
            R1 +lılardan çıkan sonuç olacak
            R2 -lilreden çıkan sonuç
            operation kullanıcıdan alınan işlemin değişkeni
            stopIt , stopIT2 ve stopIT3 döngüleri durdurmak için
            uppart ve uppartt bölme işlemin üst kısmı
            downpart ve downpart1 bölme işleminin alt kısmı
            result +lılarla -lilerin toplamı
            
            */
            
                while (stopIT3 < 1)
                {
                    try
                    {
                        while (stopIT < 1)//3 ile 30 arasında mı kontrolü
                        {
                            Console.Write("PLEASE ENTER NUMBER : ");
                            number = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            if (number <= 30 && number >= 3)
                            {
                                stopIT = 2;
                            }
                        }
                        //Console.ReadLine();//denemek için
                        while (stopIT2 < 1) //* veya / bu mu kontrolü , atanan değişken opr
                        {
                            Console.Write("PLEASE ENTER OPERATION (* OR /) : ");
                            operation = Convert.ToString(Console.ReadLine());      //burda patlayabilir , kontrol et
                            Console.WriteLine();
                            if (operation == "*" || operation == "/")
                            {
                                if (operation == "*")//burası kesin kısaltılabilir iyi düşün
                                   //*******************************************************************************
                                {
                                    for (int k = 1; k <= 115; k = k + 6)//+lıları burada hesapla
                                    {
                                        uppart = Math.Max((k * number), u2n);
                                        u2n = u2n + 100;
                                        d2n = Math.Sqrt(downpartsqrtnumber);
                                        downpartsqrtnumber = downpartsqrtnumber - 4;
                                        downpart = d1n * d2n;
                                        d1n = d1n * Math.Pow(2, 2);
                                        R1 = R1 + (uppart / downpart);

                                    }
                                    for (int l = 4; l <= 118; l = l + 6)//-lileri burada hesapla
                                    {
                                        uppartt = Math.Max(l * number, u2nn);
                                        u2nn = u2nn + 100;
                                        d2nn = Math.Sqrt(downpartsqrtnumber1);
                                        downpartsqrtnumber1 = downpartsqrtnumber1 - 4;
                                        downpart1 = d2nn * d1nn;
                                        d1nn = d1nn * Math.Pow(2, 2);
                                        R2 = R2 + (uppartt / downpart1);
                                    }

                                    result = R1 - R2;
                                    Console.WriteLine(result);

                                    //********************************************************************************
                                }
                                else //operation == "/" ise
                                     // ///////////////////////////////////////////////////////////////////////////////////
                                {
                                    for (int t = 1; t <= 115; t = t + 6)//+lıları burada hesapla
                                    {
                                        uppart = Math.Max((t * number), u2n);
                                        d2n = Math.Sqrt(downpartsqrtnumber);
                                        downpart = d1n / d2n;
                                        R1 = R1 + (uppart / downpart);


                                        u2n = u2n + 100;
                                        d1n = d1n * Math.Pow(2, 2);
                                        downpartsqrtnumber = downpartsqrtnumber - 4;

                                    }
                                    for (int u = 4; u <= 118; u = u + 6)//-lileri burada hesapla
                                    {
                                        uppartt = Math.Max(u * number, u2nn);
                                        d2nn = Math.Sqrt(downpartsqrtnumber1);
                                        downpart1 = d1nn / d2nn;
                                        R2 = R2 + (uppartt / downpart1);


                                        u2nn = u2nn + 100;
                                        downpartsqrtnumber1 = downpartsqrtnumber1 - 4;
                                        d1nn = d1nn * Math.Pow(2, 2);
                                    }
                                    result = R1 - R2;
                                    Console.WriteLine(result);


                                }
                                // ///////////////////////////////////////////////////////////////////////////////////
                                stopIT2 = 2;

                            }
                        }
                    stopIT3 = 2;
                    /*  
                   Console.WriteLine();                        
                   Console.WriteLine("QUIT  => 1");
                   Console.WriteLine();
                   Console.Write("SELECTION : ");
                   go = Convert.ToInt32(Console.ReadLine());
                   if (go == 1)
                   {
                       stopIT3 = 2;
                   }*/



                }
                    catch
                    {
                        Console.WriteLine("!!PLEASE ENTER NUMBER!!");
                        Console.WriteLine();
                    }
                
            }
            Console.ReadLine();




            //iki sonucu topla yazdır

        }
    }
}
