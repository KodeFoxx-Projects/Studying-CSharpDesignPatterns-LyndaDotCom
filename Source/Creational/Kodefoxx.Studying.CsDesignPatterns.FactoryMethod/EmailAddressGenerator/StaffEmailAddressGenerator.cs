using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Accounts;

namespace Kodefoxx.Studying.CsDesignPatterns.FactoryMethod.EmailAddressGenerator
{
    /// <summary>
    /// Generates student e-mail addresses
    /// </summary>
    public sealed class StaffEmailAddressGenerator : IEmailAddressGenerator
    {
        /// <inheritdoc />        
        public string GenerateEmailAddress(IAccount account, string domain)
            => $"{account.Person.FirstName}.{account.Person.LastName}@{domain}"
                .ToLower().Trim()
        ;
    }
}
