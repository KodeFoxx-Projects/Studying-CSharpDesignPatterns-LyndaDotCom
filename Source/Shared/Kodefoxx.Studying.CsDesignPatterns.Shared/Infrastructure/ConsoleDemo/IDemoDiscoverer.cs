using System.Collections.Generic;
using System.Reflection;

namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Infrastructure.ConsoleDemo
{
    /// <summary>
    /// Facilitates discovering demos.
    /// </summary>
    public interface IDemoDiscoverer
    {
        /// <summary>
        /// Gets all demos available.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IDemo}"/></returns>
        IEnumerable<IDemo> GetDemos();

        /// <summary>
        /// Registers a demo.
        /// </summary>
        /// <param name="assembly">The assembly to register.</param>
        void RegisterAssembly(Assembly assembly);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void RegisterAssemblyByType<T>();
    }
}
