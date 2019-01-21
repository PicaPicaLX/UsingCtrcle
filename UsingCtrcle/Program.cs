using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingCtrcle
{
    class Program
    {
        static void Main(string[] args)
        {
            //UsWhile();
            //WhilePrac();
            //UseDoWhile();
            //DoWhilePrac();
            //UseFor();
            //ForPrac();

        }

        static void UsWhile()
        {
            int iNum = 1;
            int iSum = 0;
            while (iNum<=100)
            {
                iSum += iNum;
                iNum++;
            }
            Console.WriteLine("1到100的和是：{0}", iSum);
            Console.ReadLine();
        }

        static void WhilePrac()
        {
            int iNum = 1;
            int iSum = 0;
            while (iSum<=500)
            {
                iSum += iNum;
                iNum = iNum + 2;
            }
            Console.WriteLine(iNum);
            Console.ReadLine();
        }

        static void UseDoWhile()
        {
            int iNum = 1;
            int iSum = 0;
            do
            {
                iSum += iNum;
                iNum++;
            } while (iNum<=100);
            Console.WriteLine("1加到100的和是：{0}",iSum);
            Console.ReadLine();
        }

        static void DoWhilePrac()
        {
            Console.Write("请输入你想阶乘的数字：");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int iResult = 1;
            do
            {
                iResult = iResult * i;
                i++;
            } while (i<=n);
            Console.WriteLine("{0}的阶乘是：{1}", n, iResult);
            Console.ReadLine();
        }

        static void UseFor()
        {
            int iSum = 0;
            for (int iNum = 0; iNum <=100; iNum++)
            {
                iSum += iNum;
            }
            Console.WriteLine("1加到100的值是：{0}", iSum);
            Console.ReadLine();
        }

        static void ForPrac()
        {
            int iSum1 = 0;
            int iSum2 = 0;

            for (int i = 1; i < 100; i=i+2 )
            {
                iSum1 += i;
            }

            for (int i = 2; i <= 100; i=i+2)
            {
                iSum2 += i;
            }

            Console.WriteLine("1到100之间的奇数和是：{0}\n1到100之间的偶数和是：{1}", iSum1, iSum2);
            Console.ReadLine();
        }


    }
}