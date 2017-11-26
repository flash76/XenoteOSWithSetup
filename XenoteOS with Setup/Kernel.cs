using Cosmos.Core;
using System;
using System.Collections.Generic;
using System.IO;
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
            
            for (int waitSomeTimeSoTheUserCanReadText = 10; waitSomeTimeSoTheUserCanReadText < 1000; waitSomeTimeSoTheUserCanReadText++)
            {

            }

            Console.WriteLine("\n\n\t\tWelcome to XenoteOS");
            Console.WriteLine("\n\n\tLet's set you up.");
            Console.WriteLine("Hold up, we are doing something real quick...");

            //Start the filesystem
            var fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);

            Console.WriteLine("Thanks for that, the filesystem is now enabled. FAT.");
            File.Create("0:\\setupinfo.txt");

        }

        protected override void Run()
        {
            
        }
    }
}
