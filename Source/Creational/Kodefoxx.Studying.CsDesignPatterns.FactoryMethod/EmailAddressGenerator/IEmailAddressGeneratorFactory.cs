using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain;

namespace Kodefoxx.Studying.CsDesignPatterns.FactoryMethod.EmailAddressGenerator
{
    /// <summary>
    /// Makes sure to instantiate the correct <see cref="IEmailAddressGenerator"/>.
    /// </summary>
    public interface IEmailAddressGeneratorFactory
    {
        /// <summary>
        /// Gets the appropriate <see cref="IEmailAddressGenerator"/> for a given <see cref="Account"/>.
        /// </summary>
        /// <param name="account">The <see cref="Account"/>.</param>
        /// <returns>An <see cref="IEmailAddressGenerator"/>.</returns>
        IEmailAddressGenerator GetEmailAddressGenerator(Account account);
    }
}
