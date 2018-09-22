using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain;

namespace Kodefoxx.Studying.CsDesignPatterns.FactoryMethod.EmailAddressGenerator
{
    /// <summary>
    /// Generates an e-mail address.
    /// </summary>
    public interface IEmailAddressGenerator
    {
        /// <summary>
        /// Generates an e-mail address.
        /// </summary>        
        /// <param name="account">The account to create an e-mail address for.</param>
        /// <param name="domain">The top domain used.</param>
        /// <returns>A <see cref="string"/> representing the e-mail address.</returns>
        string GenerateEmailAddress(IAccount account, string domain);
    }
}
