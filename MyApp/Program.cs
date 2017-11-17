﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            new AppHost().Init().Start("http://*:8088/");
            "ServiceStack Self Host with Razor listening at http://127.0.0.1:8088".Print();
            Process.Start("http://127.0.0.1:8088/");

            Console.ReadLine();
        }
    }
}
