using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Library.Transposition));
            host.Open();
            Console.WriteLine("Started");
            Console.ReadLine();
            host.Close();
        }
    }
}
