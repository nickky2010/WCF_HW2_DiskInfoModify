using DiskInfo;
using System;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(new DiskInfoService());
            host.Open();
            Console.WriteLine("Service is waiting for customer requests...");
            Console.ReadKey();
            host.Close();
        }
    }
}
