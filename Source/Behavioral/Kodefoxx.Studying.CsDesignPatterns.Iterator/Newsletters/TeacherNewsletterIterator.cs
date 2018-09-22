using System.Collections.Generic;
using Kodefoxx.Studying.CsDesignPatterns.Iterator.News;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.People;

namespace Kodefoxx.Studying.CsDesignPatterns.Iterator.Newsletters
{
    public sealed class TeacherNewsletterIterator : IIterator<Person>
    {
        /// <summary>
        /// Holds a reference to the writers.
        /// </summary>
        private readonly List<Person> _writers;

        /// <summary>
        /// Keeps track of the current item number.
        /// </summary>
        private int _current;

        /// <summary>
        /// Creates a new <see cref="TeacherNewsletterIterator"/> instance.
        /// </summary>
        /// <param name="writers">The people that write the newsletter.</param>
        public TeacherNewsletterIterator(List<Person> writers)
        {
            _writers = writers;
            _current = 0;
        }

        /// <inheritdoc />
        public void First()
            => _current = 0
        ;

        /// <inheritdoc />
        public Person Next()
            => _writers[_current++]
        ;

        /// <inheritdoc />
        public bool IsDone()
            => _writers.Count <= _current
        ;

        /// <inheritdoc />
        public Person CurrentItem()
            => _writers[_current]
        ;
    }
}
