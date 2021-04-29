using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.IO;

namespace BlazeInstaller
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDir = AppDomain.CurrentDomain.BaseDirectory;
            WebClient Client = new WebClient();
            Client.DownloadFile("https://github.com/Grayson9352/BlazeLauncher/raw/main/BlazeApp.exe", currentDir + "BlazeApp.exe");
            Thread.Sleep(1000); // TODO: Implement real download complete checker
            if (File.Exists(currentDir + "BlazeApp.exe"))
            {
                Console.WriteLine("Finished Downloading!");
            }
            else
            {
                Thread.Sleep(3000);
                if (File.Exists(currentDir + "BlazeApp.exe"))
                {
                    Console.WriteLine("Could not install, please try again.");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }
            }
            Console.Read();
        }
    }
}
