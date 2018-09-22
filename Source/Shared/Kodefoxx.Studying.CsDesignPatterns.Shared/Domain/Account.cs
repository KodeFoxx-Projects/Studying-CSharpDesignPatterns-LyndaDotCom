using System.Diagnostics;

namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Domain
{
    /// <summary>
    /// Represents an account.
    /// </summary>
    [DebuggerDisplay("{Id} | {Person.FirstName} {Person.LastName}")]
    public class Account : IAccount
    {        
        /// <inheritdoc />
        public string Id { get; }

        /// <inheritdoc />
        public AccountType Type { get; }

        /// <inheritdoc />
        public Person Person { get; }

        /// <inheritdoc />
        public string EmailAddress { get; set; }

        /// <summary>
        /// Creates a new <see cref="Account"/> instance.
        /// </summary>
        /// <param name="accountType">The type of account.</param>
        /// <param name="person">The person who's the owner of this account.</param>
        /// <param name="emailAddress">The (optional) e-mail address attached to this account.</param>
        public Account(AccountType accountType, Person person, string emailAddress = null)
        {
            Id = $"{accountType.ToString().ToUpper()}{person.Id}";
            Type = accountType;
            Person = person;
            EmailAddress = emailAddress;
        }

        /// <inheritdoc />
        public override string ToString()
            => $"{Id} | {Person.FirstName} {Person.LastName}"
        ;
    }
}
