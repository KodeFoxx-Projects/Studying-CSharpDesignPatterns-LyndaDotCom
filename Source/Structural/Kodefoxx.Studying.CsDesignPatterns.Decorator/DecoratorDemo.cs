using System.IO;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Infrastructure.ConsoleDemo;

namespace Kodefoxx.Studying.CsDesignPatterns.Decorator
{
    /// <summary>
    /// Demo showcasing the Abstract Factory.
    /// </summary>
    public sealed class DecoratorDemo : Demo
    {
        /// <summary>
        /// Creates a new <see cref="DecoratorDemo"/> instance.
        /// </summary>
        public DecoratorDemo() 
            : base("Decorator", null)
        { }
        
        /// <inheritdoc />        
        public override void Run(TextWriter log) { }        
    }
}
