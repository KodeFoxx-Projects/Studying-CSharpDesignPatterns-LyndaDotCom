using System;
using Kodefoxx.Studying.CsDesignPatterns.FactoryMethod;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Infrastructure.ConsoleDemo;
using Kodefoxxx.Studying.CsDesignPatterns.AbstractFacto;

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
            RegisterAssemblyByType<AbstractFactoryDemo>();
        }        
    }
}
