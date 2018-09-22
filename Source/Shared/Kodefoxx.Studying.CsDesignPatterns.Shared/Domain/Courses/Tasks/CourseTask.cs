using System;

namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Courses.Tasks
{
    /// <summary>
    /// Defines a course task.
    /// </summary>
    public sealed class CourseTask
    {
        /// <summary>
        /// The task's description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// The task's due date.
        /// </summary>
        public DateTime DueDate { get; }

        /// <summary>
        /// Creates a <see cref="CourseTask"/> instance.
        /// </summary>
        /// <param name="description">The task's description.</param>
        /// <param name="dueDate">The task's due date.</param>
        public CourseTask(string description, DateTime dueDate)
        {
            Description = description;
            DueDate = dueDate;
        }
        
        /// <inheritdoc />        
        public override string ToString()
            => $"{DueDate:D} | {Description}"
        ;
    }
}
