﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_ExtentionMethod
{
    public static class MyUtils
    {
        //cai dat ham tinh tong tu 1 den n vao kieu int cua microsoft
        public static int TongTu1ToiN(this int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++) 
                {
                    sum += i;
                }
                return sum;
        }
        public static void SapXepTangDan(this int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i;j<arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j]; ;
                        arr[j] = temp;
                    }
                }
            }
        }
        public static void TaoMangNgauNhien(this int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(100);
            }
        }
        public static void XuatMang(this int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
    }
}
