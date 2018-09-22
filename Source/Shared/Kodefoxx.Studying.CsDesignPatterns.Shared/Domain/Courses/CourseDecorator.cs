namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Courses
{
    /// <summary>
    /// Implements the Decorator pattern so one can add features on top of it.
    /// Note: part of the Decorator Pattern, this is a "Decorator".
    /// </summary>
    public class CourseDecorator : Course
    {
        /// <summary>
        /// Holds a reference to the <see cref="Course"/> we're decorating.
        /// </summary>
        protected Course _course;

        /// <summary>
        /// Creates a new <see cref="CourseDecorator"/> instance.
        /// </summary>
        /// <param name="course">The <see cref="Course"/> to be decorated.</param>
        public CourseDecorator(Course course)
            : base(course.Name)
            => _course = course
        ;
        
        /// <inheritdoc />
        public override string Description => _course.Description;

        /// <inheritdoc />
        public override double Price => _course.Price;
    }
}
