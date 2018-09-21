using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Infrastructure.ConsoleDemo
{
    /// <summary>
    /// Facilitates running and discovering <see cref="IDemo"/>s.
    /// </summary>
    public abstract class DemoProgram : IDemoDiscoverer, IDemoRunner
    {
        /// <summary>
        /// Stores the registered assemblies.
        /// </summary>
        private readonly List<Assembly> _assemblies
            = new List<Assembly>();

        /// <inheritdoc cref="IDemoDiscoverer"/>
        public IEnumerable<IDemo> GetDemos()
            => _assemblies                
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type =>
                        type.Name.EndsWith("Demo")
                        && type.IsClass
                        && !type.IsAbstract
                        && !type.IsInterface
                        && typeof(IDemo).IsAssignableFrom(type)
                )
                .Select(type => Activator.CreateInstance(type) as IDemo)
        ;

        /// <inheritdoc cref="IDemoDiscoverer"/>
        public void RegisterAssembly(Assembly assembly)
            => _assemblies.Add(assembly)
        ;

        /// <inheritdoc cref="IDemoDiscoverer"/>
        public void RegisterAssemblyByType<T>()
            => _assemblies.Add(typeof(T).Assembly)
        ;

        /// <inheritdoc cref="IDemoRunner"/>
        public void Run()
        {
            RegisterAssemblies();

            try
            {
                GetDemos().ToList().ForEach(demo =>
                {
                    var headerAndFooter = GetHeaderAndFooter(demo);
                    Console.WriteLine(headerAndFooter.Header);
                    RunDemo(demo);
                    Console.WriteLine(headerAndFooter.Footer);
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Gets the header and footer based on the given <param name="demo"></param>.
        /// </summary>
        /// <param name="demo">The <see cref="IDemo"/> to calculate the header and footer of.</param>
        /// <returns>A tuple containing the header and footer.</returns>
        private (string Header, string Footer) GetHeaderAndFooter(IDemo demo)
        {
            var lineWidth = Console.WindowWidth;

            var footer = new string('=', lineWidth);
            var headerText = $" {demo.Pattern} ";
            var headerFiller = new string('=', (lineWidth - headerText.Length) / 2);
            var header = $"{headerFiller}{headerText}{headerFiller}";

            return (header, footer);
        }

        /// <inheritdoc cref="IDemoRunner"/>
        public abstract void RunDemo(IDemo demo);

        /// <inheritdoc cref="IDemoRunner"/>
        public abstract void RegisterAssemblies();        
    }
}