using System.Collections.Generic;
using System.Linq;
using Kodefoxx.Studying.CsDesignPatterns.Iterator.News;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.People;

namespace Kodefoxx.Studying.CsDesignPatterns.Iterator.Newsletters
{
    public sealed class TeacherNewsletter : INewsletter
    {
        /// <summary>
        /// Holds the people writing the newsletter.
        /// </summary>
        private readonly List<Person> _reporters;

        /// <inheritdoc />
        public string Name
            => "News for Teachers"
        ;

        /// <summary>
        /// Creates a new <see cref="TeacherNewsletter"/> instance.
        /// </summary>
        public TeacherNewsletter()
            => _reporters = new[]
            {
                new Person(33541, "Els", "Maenen"),
            }.ToList()
        ;

        /// <inheritdoc />
        public IIterator<Person> GetIterator()
            => new TeacherNewsletterIterator(_reporters)
        ;
    }
}
