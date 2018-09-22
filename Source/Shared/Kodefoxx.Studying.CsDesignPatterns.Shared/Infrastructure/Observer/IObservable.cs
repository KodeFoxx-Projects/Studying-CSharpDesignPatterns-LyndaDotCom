namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Infrastructure.Observer
{
    /// <summary>
    /// Contract for an observable object.
    /// </summary>
    /// <typeparam name="TObservable">The type of the object being observed.</typeparam>
    /// <typeparam name="TObserver">The type of the object that's observing.</typeparam>
    public interface IObservable<TObservable, TObserver>        
        where TObserver : IObserver<TObservable>
    {
        /// <summary>
        /// Notifies all observers.
        /// </summary>
        /// <param name="observable">The observable object which state has changed.</param>
        void Notify(TObservable observable);

        /// <summary>
        /// Adds an <see cref="IObserver{TObservable}"/>.
        /// </summary>
        /// <param name="observer">The concrete observer to add.</param>
        void AddObserver(TObserver observer);

        /// <summary>
        /// Removes an <see cref="IObserver{TObservable}"/>.
        /// </summary>
        /// <param name="observer">The concrete observer to remove.</param>
        void RemoveObserver(TObserver observer);
    }
}
