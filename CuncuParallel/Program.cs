using System;
using System.Threading.Tasks;

namespace CuncuParallel
{
    class Program
    {
        static void Main(string[] args)
        {
            DownloadFileOne();
            DownloadFileTwo();
            //Task.Factory.StartNew(DownloadFileThree);
            //Task.Factory.StartNew(DownloadFileFour);

            string s = "";// Console.ReadLine();
            Console.WriteLine("User entered: " + s);
            Console.ReadLine();
        }
        static async void DownloadFileOne()
        {
            await Task.Delay(10000);
            Console.WriteLine("Downloading file1!");
        }
        static async void DownloadFileTwo()
        {
            await Task.Delay(10000);
            Console.WriteLine("Downloading file2!");

        }
        static  void DownloadFileThree()
        {
             Task.Delay(10000);
            Console.WriteLine("Downloading file3!");
        }
        static  void DownloadFileFour()
        {
             Task.Delay(10000);
            Console.WriteLine("Downloading file4!");
        }
    }
}
