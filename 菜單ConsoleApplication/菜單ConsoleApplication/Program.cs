using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//objective:練習條件式判斷if語法
//date:2018.09.26
//author:林紘毅

namespace 菜單ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int teaAmount;//紅茶的杯數
            int milkteaAmount;//奶茶的杯數
            string answer;//回答是否為會員
            double total;//總價

            //詢問使用者紅茶的杯數
            Console.WriteLine("紅茶一杯100元，要幾杯");
            teaAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("奶茶一杯200元，要幾杯");
            milkteaAmount = int.Parse(Console.ReadLine());

            //計算消費總和
            total = teaAmount * 100 + milkteaAmount * 200;
            //詢問是否為會員
            Console.WriteLine("請問是會員嗎，如果是請按是");
            answer = Console.ReadLine();
            // 如果是會員，可享九折優待
            if (answer == "是")
            {
                total = total*0.9 ;
            }
            Console.WriteLine("應收金額為: "+total.ToString());

            Console.ReadLine();

        }
    }
}
