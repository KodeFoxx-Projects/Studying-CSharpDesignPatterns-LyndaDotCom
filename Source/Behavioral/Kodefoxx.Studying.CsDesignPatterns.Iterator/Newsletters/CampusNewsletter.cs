using Kodefoxx.Studying.CsDesignPatterns.Iterator.News;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.People;

namespace Kodefoxx.Studying.CsDesignPatterns.Iterator.Newsletters
{
    /// <summary>
    /// Defines the campus newsletter.
    /// </summary>
    public sealed class CampusNewsletter : INewsletter
    {
        /// <summary>
        /// Holds the staff writing the newsletter.
        /// </summary>
        private readonly Person[] _staff;

        /// <inheritdoc />
        public string Name 
            => "Campus News"
        ;

        /// <summary>
        /// Creates a new <see cref="CampusNewsletter"/> instance.
        /// </summary>
        public CampusNewsletter()
            => _staff = new[]
            {
                new Person(10245, "Yves", "Schelpe"),
                new Person(11547, "Geert", "Verdrongen"),
                new Person(12578, "Karel", "de Slechte"),
            }
        ;

        /// <inheritdoc />
        public IIterator<Person> GetIterator()
            => new CampusNewsletterIterator(_staff)
        ;
    }
}
