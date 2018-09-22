using Kodefoxx.Studying.CsDesignPatterns.Iterator.News;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.People;

namespace Kodefoxx.Studying.CsDesignPatterns.Iterator.Newsletters
{
    /// <summary>
    /// An <see cref="IIterator"/> for a <see cref="CampusNewsletter"/>.
    /// </summary>
    public sealed class CampusNewsletterIterator : IIterator<Person>
    {
        /// <summary>
        /// Holds a reference to the writers.
        /// </summary>
        private readonly Person[] _writers;

        /// <summary>
        /// Keeps track of the current item number.
        /// </summary>
        private int _current;

        /// <summary>
        /// Creates a new <see cref="CampusNewsletterIterator"/> instance.
        /// </summary>
        /// <param name="writers">The people that write the newsletter.</param>
        public CampusNewsletterIterator(Person[] writers)
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
            => _writers.Length <= _current
        ;

        /// <inheritdoc />
        public Person CurrentItem()
            => _writers[_current]
        ;
    }
}
