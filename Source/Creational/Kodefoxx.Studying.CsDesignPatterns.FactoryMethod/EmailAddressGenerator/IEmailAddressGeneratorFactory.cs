using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Accounts;

namespace Kodefoxx.Studying.CsDesignPatterns.FactoryMethod.EmailAddressGenerator
{
    /// <summary>
    /// Makes sure to instantiate the correct <see cref="IEmailAddressGenerator"/>.
    /// </summary>
    public interface IEmailAddressGeneratorFactory
    {
        /// <summary>
        /// Gets the appropriate <see cref="IEmailAddressGenerator"/> for a given <see cref="IAccount"/>.
        /// </summary>
        /// <param name="account">The <see cref="IAccount"/>.</param>
        /// <returns>An <see cref="IEmailAddressGenerator"/>.</returns>
        IEmailAddressGenerator GetEmailAddressGenerator(IAccount account);
    }
}
