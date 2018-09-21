using System;
using System.Linq;
using Kodefoxx.Studying.CsDesignPatterns.FactoryMethod;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Infrastructure.ConsoleDemo;

namespace Kodefoxx.Studying.CsDesignPatterns.Runner
{
    class Program : DemoProgram
    {
        static void Main(string[] args)
        {
            new Program().Run();
            Console.ReadLine();
        }

        public override void RegisterAssemblies()
        {
            RegisterAssemblyByType<FactoryMethodDemo>();
        }        
    }
}
