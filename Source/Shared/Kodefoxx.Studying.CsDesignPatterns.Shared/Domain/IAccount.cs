namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Domain
{
    /// <summary>
    /// Represents an account.
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// The account's unique identifier.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// The type of account.
        /// </summary>
        AccountType Type { get; }

        /// <summary>
        /// The person who's the owner of this account.
        /// </summary>
        Person Person { get; }

        /// <summary>
        /// Gets/sets the e-mail address attached to this account.
        /// </summary>
        string EmailAddress { get; set; }
    }
}
