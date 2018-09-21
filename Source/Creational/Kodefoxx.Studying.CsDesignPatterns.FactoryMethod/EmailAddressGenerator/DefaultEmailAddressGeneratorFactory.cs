using System;
using System.Collections.Generic;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain;

namespace Kodefoxx.Studying.CsDesignPatterns.FactoryMethod.EmailAddressGenerator
{
    /// <summary>
    /// Default implementation for creating <see cref="IEmailAddressGenerator"/> instances.
    /// </summary>
    public sealed class DefaultEmailAddressGeneratorFactory : IEmailAddressGeneratorFactory
    {
        /// <summary>
        /// Holds the mapping between <see cref="AccountType"/> and <see cref="IEmailAddressGenerator"/> implementations.
        /// </summary>
        private readonly Dictionary<AccountType, Func<IEmailAddressGenerator>> _accountToEmailAddressGeneratorMap = 
            new Dictionary<AccountType, Func<IEmailAddressGenerator>>
            {
                { AccountType.Staff, () => new StaffEmailAddressGenerator() },
                { AccountType.Student, () => new StudentEmailAddressGenerator() },
            }
        ;

        /// <inheritdoc />
        public IEmailAddressGenerator GetEmailAddressGenerator(Account account)
            => _accountToEmailAddressGeneratorMap.ContainsKey(account.Type)
                ? _accountToEmailAddressGeneratorMap[account.Type]()
                : throw new ArgumentException(
                    message: $"No {typeof(IEmailAddressGenerator).Name} implementation exists for account type '{account.Type}'.",
                    paramName: nameof(account)
                  )
        ;
    }
}
