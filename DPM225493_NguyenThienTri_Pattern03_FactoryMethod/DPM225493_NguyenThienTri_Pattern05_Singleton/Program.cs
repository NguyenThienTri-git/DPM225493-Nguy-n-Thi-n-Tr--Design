﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern05_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();
            
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }
            
            Console.ReadKey();
        }
    }
}
