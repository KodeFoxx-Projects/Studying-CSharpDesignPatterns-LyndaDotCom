using System.Diagnostics;

namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Courses
{
    /// <summary>
    /// Defines a course.
    /// Note: part of the Decorator Pattern, this is a "Component"
    /// </summary>
    [DebuggerDisplay("{Name} | {Price} | {Description}")]
    public abstract class Course
    {
        /// <summary>
        /// Gets the course's name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the course's description.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Gets the course's price.
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Creates a new <see cref="Course"/> instance.
        /// </summary>
        /// <param name="name">The name of the course.</param>
        protected Course(string name)
            => Name = name;

        /// <inheritdoc />
        public override string ToString()
            => $"{Name} | {Price} | {Description}"
        ;
    }
}
