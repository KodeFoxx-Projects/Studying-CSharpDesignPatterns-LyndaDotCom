using System;
using System.IO;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Accounts;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Courses;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.People;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Infrastructure.ConsoleDemo;

namespace Kodefoxx.Studying.CsDesignPatterns.Observer
{
    /// <summary>
    /// Demo showcasing the Observer.
    /// </summary>
    public sealed class ObserverDemo : Demo
    {
        /// <summary>
        /// Creates a new <see cref="ObserverDemo"/> instance.
        /// </summary>
        public ObserverDemo() 
            : base("Observer", null)
        { }

        /// <inheritdoc />        
        public override void Run(TextWriter log)
        {
            var accounts = new Account[]
            {
                new Account(
                    AccountType.Student, 
                    new Person(19851110, "Yves", "Schelpe"),
                    "yves.schelpe@student.school.edu",
                    (cT, a) =>
                    {
                        log.WriteLine($"- '{a.Id}' received task '{cT.Description}' due on '{cT.DueDate:d}'.");
                    }
                )
            };

            var course = new SimpleCourse("Biology 101", "Introduction to biology", 35d);
            course.TaskManager.AddObserver(accounts[0]);

            course.TaskManager.AddTask("Paper on the eye", DateTime.Now.AddDays(7));            
        }        
    }
}
