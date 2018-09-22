using System.IO;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Courses;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Courses.Modules;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Infrastructure.ConsoleDemo;

namespace Kodefoxx.Studying.CsDesignPatterns.Decorator
{
    /// <summary>
    /// Demo showcasing the Decorator.
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
        public override void Run(TextWriter log)
        {
            var biology101Course = new SimpleCourse("Biology 101", "Introduction to biology", 30.45d);
            var math101Course = new SimpleCourse("Math 101", "Introduction to math", 30.45d);
            var psychology101Course = new SimpleCourse("Psychology 101", "Introduction to psychology", 30.45d);

            var myEnrolledCourses = new[]
            {
                new ExamModule(biology101Course),
                new ExamModule(
                    new SupportModule(math101Course)                    
                ),
                new ExamModule(
                    new SupportModule(
                        new SpecialAssistanceModule(psychology101Course)
                    )
                ),
            };

            log.WriteLine($"My enrolled courses:");
            foreach (var course in myEnrolledCourses)
            {
                log.WriteLine($"- {course.Name}:");
                log.WriteLine($"   Price: EUR {course.Price:N}");
                log.WriteLine($"   Description: {course.Description}");
            }
        }        
    }
}
