using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name: ");
            var name = string.Empty;

            while(!(name=Console.ReadLine()).Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                var client = new HelloWorldService.HelloWorldServiceClient();
                Console.WriteLine(client.HelloWorld(name));
                Console.WriteLine("type 'exit' to close application or enter another name");
            }

            Environment.Exit(0);
        }
    }
}
