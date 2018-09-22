using System.IO;
using Kodefoxx.Studying.CsDesignPatterns.Iterator.News;
using Kodefoxx.Studying.CsDesignPatterns.Iterator.Newsletters;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Courses;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Courses.Modules;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Infrastructure.ConsoleDemo;

namespace Kodefoxx.Studying.CsDesignPatterns.Iterator
{
    /// <summary>
    /// Demo showcasing the Abstract Factory.
    /// </summary>
    public sealed class IteratorDemo : Demo
    {
        /// <summary>
        /// Creates a new <see cref="IteratorDemo"/> instance.
        /// </summary>
        public IteratorDemo() 
            : base("Iterator", null)
        { }

        /// <inheritdoc />        
        public override void Run(TextWriter log)
        {
            var newsletters = new INewsletter[]
            {
                new CampusNewsletter(),
                new TeacherNewsletter()
            };

            foreach (var newsletter in newsletters)
            {
                log.WriteLine($"- '{newsletter.Name}' writers/staff:");

                var iterator = newsletter.GetIterator();
                while (!iterator.IsDone())                
                    log.WriteLine($"  - {iterator.Next()}");                
            }
        }        
    }
}
