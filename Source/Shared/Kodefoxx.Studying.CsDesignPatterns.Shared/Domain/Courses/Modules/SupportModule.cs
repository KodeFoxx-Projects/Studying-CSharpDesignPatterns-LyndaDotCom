namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Courses.Modules
{
    /// <summary>
    /// A module that provides extra support/assistance.
    /// </summary>
    public sealed class SupportModule : CourseDecorator
    {
        /// <summary>
        /// Creates a new <see cref="SupportModule"/> instance.
        /// </summary>
        /// <param name="course">The course getting enhanced support.</param>
        public SupportModule(Course course)
            : base(course)
        { }
        
        /// <inheritdoc />
        public override string Description
            => $"{_course.Description}, Support"
        ;

        /// <inheritdoc />
        public override double Price
            => _course.Price + 25.15d
        ;
    }
}
