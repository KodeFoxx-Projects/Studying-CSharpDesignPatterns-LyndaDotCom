namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Infrastructure.Observer
{
    /// <summary>
    /// An object that observes a <typeparamref name="TObservable"/>
    /// </summary>
    /// <typeparam name="TObservable">The type of the object being observed.</typeparam>
    public interface IObserver<TObservable>
    {
        /// <summary>
        /// Updates the observer with new state.
        /// </summary>
        /// <param name="observable">The new state.</param>
        void Update(TObservable observable);
    }
}
