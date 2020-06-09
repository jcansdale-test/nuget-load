using System;
using System.Reflection;

namespace consume_test
{
    class Program
    {
        static int Main(string[] args)
        {
            var assemblyName = "nuget-load";
            var asm = Assembly.Load(assemblyName);
            var version = asm.GetName().Version.ToString();
            Console.WriteLine($"Assembly version: {version}");

            if(args.Length > 0)
            {
                var expectedVersion = args[0];
                if (version == expectedVersion)
                {
                    Console.WriteLine($"Assembly `{assemblyName}` was expected version `{expectedVersion}`!");
                    return 0;
                }
                else
                {
                    Console.WriteLine($"Assembly `{assemblyName}` was `{version}` not expected version `{expectedVersion}`!");
                    return 1;
                }
            }

            return 0;
        }
    }
}
