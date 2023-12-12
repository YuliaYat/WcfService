﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(Service.Service)))
            {
                host.Open();
                Console.WriteLine("Host is started");
                Console.ReadLine();
            }
        }
    }
}
