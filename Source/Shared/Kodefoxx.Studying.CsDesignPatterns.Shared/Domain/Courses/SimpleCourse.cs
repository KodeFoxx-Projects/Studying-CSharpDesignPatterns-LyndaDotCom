using System.Diagnostics;

namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Courses
{
    /// <summary>
    /// Defines a simple <see cref="Course"/>.
    /// Note: part of the Decorator Pattern, this is a "ConcreteComponent", as it implements a "Component".
    /// </summary>
    [DebuggerDisplay("{Name} | {Price} | {Description}")]
    public sealed class SimpleCourse : Course
    {
        /// <inheritdoc />
        public SimpleCourse(string name, string description, double price)
            : base(name)
        {
            Description = description;
            Price = price;
        }

        /// <inheritdoc />
        public override string Description { get; }

        /// <inheritdoc />
        public override double Price { get; }
    }
}
