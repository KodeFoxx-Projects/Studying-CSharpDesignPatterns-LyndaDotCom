using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain;

namespace Kodefoxxx.Studying.CsDesignPatterns.AbstractFacto.Accounts
{
    /// <summary>
    /// Makes sure to instantiate the correct factory for creating <see cref="IAccount"/>s.
    /// </summary>
    public interface IAccountFactory
    {
        /// <summary>
        /// Creates a staff account for a given <paramref name="person"/>.
        /// </summary>
        /// <param name="person">The <see cref="Person"/> to create a staff <see cref="IAccount"/> for.</param>
        /// <returns>A staff <see cref="IAccount"/>.</returns>
        IAccount CreateStaffAccount(Person person);

        /// <summary>
        /// Creates a student account for a given <paramref name="person"/>.
        /// </summary>
        /// <param name="person">The <see cref="Person"/> to create a student <see cref="IAccount"/> for.</param>
        /// <returns>A student <see cref="IAccount"/>.</returns>
        IAccount CreateStudentAccount(Person person);
    }
}
