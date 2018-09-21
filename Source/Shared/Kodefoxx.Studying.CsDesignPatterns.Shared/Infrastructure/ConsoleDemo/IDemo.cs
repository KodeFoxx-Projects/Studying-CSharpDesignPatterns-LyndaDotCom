using System;
using System.IO;

namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Infrastructure.ConsoleDemo
{
    /// <summary>
    /// Defines a demonstration.
    /// </summary>
    public interface IDemo
    {        
        /// <summary>
        /// The name of the pattern being demo'd.
        /// </summary>
        string Pattern { get; }

        /// <summary>
        /// The - optional - description of the demo.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The actual <see cref="System.Console"/> implementation of the demo.
        /// </summary>
        void Run(TextWriter log);
    }
}
