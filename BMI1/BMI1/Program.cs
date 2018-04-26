using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static readonly double a;

        static void Main(string[] args)

        {

            // 定義
            Console.Write("請輸入身高(公分)：");
            string length = Console.ReadLine();

            Console.Write("請輸入體重(公斤)：");
            string weight = Console.ReadLine();


            // 計算BMI
            double w = double.Parse(weight);
            double h = double.Parse(length) / 100;
            double bmi = w / (h * h);
            Console.WriteLine("您的BMI值為：" + bmi.ToString());

            // 顯示結果
            if (bmi < 17)
            {
                Console.WriteLine("體重過輕，不用當兵");
            }
            if (bmi < 18.5)
            {
                Console.WriteLine("體重過輕但還是要當兵");
            }

            if (bmi >= 18.5 && bmi < 24)
            {
                Console.WriteLine("正常範圍，必須當兵");
            }

            if (bmi >= 24 && bmi < 31)
            {
                Console.WriteLine("過重，可是要當兵");
            }


            if (bmi > 31)
            {
                Console.WriteLine("過重，胖到不用當兵");
            }



            //  Console.BackgroundColor = ConsoleColor.White;
            //  Console.ForegroundColor = ConsoleColor.Red;
            //  Console.WriteLine("╔═══════╗");
            //  Console.WriteLine("║    D M A     ║");
            //  Console.WriteLine("╚═══════╝");

            // double rate = 4.61931155;
            //  Console.WriteLine("目前人民幣兌台幣：" + rate);
            //  Console.Write("請輸入人民幣金額：");
            //  string input = Console.ReadLine();

            //  double total = int.Parse(input) * rate;
            //   Console.WriteLine("等於台幣：" + total);

            Console.ReadLine();
        }
    }
}
