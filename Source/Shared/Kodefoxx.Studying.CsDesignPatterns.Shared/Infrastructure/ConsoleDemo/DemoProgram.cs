using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

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
                    Console.WriteLine();
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
            var padding = "  ";
            var lineWidth = (Console.WindowWidth + (padding.Length * 2)) / 3;

            var footer = $"{padding}{new string('=', lineWidth * 2)}{padding}";
            var headerText = $" {demo.Pattern} ";
            var headerFiller = new string('=', (lineWidth * 2 - headerText.Length) / 2);
            var header = $"{padding}{headerFiller}{headerText}{headerFiller}{padding}";

            if (header.Length != footer.Length)
                header = $"{header.Substring(0, lineWidth * 2)}=={padding}";

            return (header, footer);
        }

        /// <inheritdoc cref="IDemoRunner"/>
        public virtual void RunDemo(IDemo demo)
        {
            var log = new StringBuilder();
            var logWriter = new StringWriter(log);

            demo.Run(logWriter);

            foreach (var line in log.ToString().Split(new [] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                Console.WriteLine($"    {line}");            
        }        

        /// <inheritdoc cref="IDemoRunner"/>
        public abstract void RegisterAssemblies();        
    }
}