using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.People;

namespace Kodefoxx.Studying.CsDesignPatterns.Iterator.News
{
    /// <summary>
    /// Defines a newsletter.
    /// </summary>
    public interface INewsletter
    {
        /// <summary>
        /// Gets the name of the newsletter.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the iterator for the specific <see cref="INewsletter"/>.
        /// </summary>
        /// <returns>An <see cref="IIterator"/>.</returns>
        IIterator<Person> GetIterator();
    }
}
