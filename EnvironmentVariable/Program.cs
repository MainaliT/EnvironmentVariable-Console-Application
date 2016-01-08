using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentVariable
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Machine Name: {0} ", Environment.MachineName);
            Console.WriteLine("CurrentDirectory: {0} ", Environment.CurrentDirectory);
            Console.WriteLine("SystemDirectory: {0} ", Environment.SystemDirectory);
            Console.WriteLine("UserDommain: {0} ", Environment.UserDomainName);
            Console.WriteLine("UserName: {0} ", Environment.UserName);
            Console.WriteLine("WorkingSet: {0} ", Environment.WorkingSet);

            Console.ReadLine();
        }

       
    }
}











































































