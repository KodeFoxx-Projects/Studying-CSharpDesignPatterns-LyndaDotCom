namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Courses.Modules
{
    /// <summary>
    /// A module that provides the right to take part in an examination.
    /// </summary>
    public sealed class ExamModule : CourseDecorator
    {
        /// <summary>
        /// Creates a new <see cref="ExamModule"/>.
        /// </summary>
        /// <param name="course">The course getting exam rights.</param>
        public ExamModule(Course course) 
            : base(course)
        { }

        /// <inheritdoc />
        public override string Description
            => $"{_course.Description}, Exam"
        ;

        /// <inheritdoc />
        public override double Price
            => _course.Price + 15d
        ;
    }
}
