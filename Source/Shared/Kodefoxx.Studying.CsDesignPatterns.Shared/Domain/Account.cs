using System.Diagnostics;

namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Domain
{
    /// <summary>
    /// Represents an account.
    /// </summary>
    [DebuggerDisplay("{Id} | {Person.FirstName} {Person.LastName}")]
    public class Account
    {
        /// <summary>
        /// The account's unique identifier.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// The type of account.
        /// </summary>
        public AccountType Type { get; }

        /// <summary>
        /// The person who's the owner of this account.
        /// </summary>
        public Person Person { get; }

        /// <summary>
        /// Creates a new <see cref="Account"/> instance.
        /// </summary>
        /// <param name="accountType">The type of account.</param>
        /// <param name="person">The person who's the owner of this account.</param>
        public Account(AccountType accountType, Person person)
        {
            Id = $"{accountType.ToString().ToUpper()}{person.Id}";
            Type = accountType;
            Person = person;
        }

        /// <inheritdoc />
        public override string ToString()
            => $"{Id} | {Person.FirstName} {Person.LastName}"
        ;
    }
}
