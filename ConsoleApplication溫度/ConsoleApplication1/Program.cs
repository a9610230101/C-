using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//author : 林紘毅 A107222011
//project : 華氏攝氏溫度轉換
//date : 2018/09/26

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("攝氏轉華氏請選1，華氏轉攝氏請選2");
            int S = Convert.ToInt32(System.Console.ReadLine());

            if (S == 1)
            {
                System.Console.WriteLine("請輸入攝氏溫度");
                int a = int.Parse(System.Console.ReadLine());
                double b = a * 9 / 5.0 + 32;

                System.Console.WriteLine("華氏溫度為:" + b);
                System.Console.ReadKey();
            }

            else if (S == 2)
            {
                System.Console.WriteLine("請輸入華氏溫度");
                int a = int.Parse(System.Console.ReadLine());
                double b = (a + 40) / 1.8 - 40;

                System.Console.WriteLine("華氏溫度為:" + b);
                System.Console.ReadKey();
            }
        }
    }
}





