namespace Kodefoxx.Studying.CsDesignPatterns.Iterator.News
{
    /// <summary>
    /// Defines an iterator for <typeparam name="T"></typeparam>.
    /// </summary>
    /// <typeparam name="T">The type of instances the iterator cycles though.</typeparam>
    public interface IIterator<T>
    {
        /// <summary>
        /// Sets the <see cref="CurrentItem"/> to the first element.
        /// </summary>
        void First();

        /// <summary>
        /// Advances the <see cref="CurrentItem"/> to the next element.
        /// </summary>
        /// <returns>A <see cref="string"/> representing the next element.</returns>
        T Next();

        /// <summary>
        /// Determines if we reached the end of the collection.
        /// </summary>
        /// <returns>True when we reached the end of the collection; false if not.</returns>
        bool IsDone();

        /// <summary>
        /// Gets the current element/item/
        /// </summary>
        /// <returns>A <see cref="string"/> representing the current element.</returns>
        T CurrentItem();
    }
}