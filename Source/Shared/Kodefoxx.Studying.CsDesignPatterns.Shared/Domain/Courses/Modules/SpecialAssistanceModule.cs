using System;
using System.Collections.Generic;
using System.Text;

namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Courses.Modules
{
    /// <summary>
    /// A module providing special assistance.
    /// </summary>
    public sealed class SpecialAssistanceModule : CourseDecorator
    {
        /// <summary>
        /// Creates a new <see cref="SpecialAssistanceModule"/>.
        /// </summary>
        /// <param name="course">The course getting special assistance rights.</param>
        public SpecialAssistanceModule(Course course)
            : base(course)
        { }

        /// <inheritdoc />
        public override string Description
            => $"{_course.Description}, Special assistance"
        ;

        /// <inheritdoc />
        public override double Price
            => _course.Price + 0d
        ;
    }
}
