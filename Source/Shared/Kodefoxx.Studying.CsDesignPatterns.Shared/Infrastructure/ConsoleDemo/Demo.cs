using System;
using System.IO;

namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Infrastructure.ConsoleDemo
{
    /// <summary>
    /// Base implementation for a <see cref="IDemo"/>.
    /// </summary>
    public abstract class Demo : IDemo
    {
        /// <inheritdoc />
        public string Pattern { get; }

        /// <inheritdoc />
        public string Description { get; }

        /// <summary>
        /// Creates a new <see cref="Demo"/> instance.
        /// </summary>
        /// <param name="patternName">The name of the pattern.</param>
        /// <param name="description">The - optional - description of the demo.</param>
        protected Demo(string patternName, string description = null)
        {
            Pattern = patternName;
            Description = description;
        }

        /// <inheritdoc />
        public abstract void Run(TextWriter log);
    }
}
