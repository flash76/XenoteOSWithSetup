using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace XenoteOS_with_Setup
{
    public class Kernel: Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("__   __                 _        _____ _____ \r\n\\ \\ / /                | |      |  _  /  ___|\r\n \\ V /  ___ _ __   ___ | |_ ___ | | | \\ `--. \r\n /   \\ / _ \\ '_ \\ / _ \\| __/ _ \\| | | |`--. \\\r\n/ /^\\ \\  __/ | | | (_) | ||  __/\\ \\_/ /\\__/ /\r\n\\/   \\/\\___|_| |_|\\___/ \\__\\___| \\___/\\____/ \r\n                                             \r\n     ");
            Console.WriteLine("(c) 2017 by Varun Somashekar\n This software is made available under the Apache Licence 2.0");
        }
        
        protected override void Run()
        {
            string setupBorder = "";

            for (int i = 0; i < 40; i++)
            {
                setupBorder += "=";
            }

            Console.WriteLine("\tWelcome to XenoteOS");

            Console.WriteLine("Let's set you up.");
        }
    }
}
