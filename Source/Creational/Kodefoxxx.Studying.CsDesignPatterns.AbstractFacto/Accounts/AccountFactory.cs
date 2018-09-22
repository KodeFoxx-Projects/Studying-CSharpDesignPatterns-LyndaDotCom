using Kodefoxx.Studying.CsDesignPatterns.FactoryMethod.EmailAddressGenerator;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain;

namespace Kodefoxxx.Studying.CsDesignPatterns.AbstractFacto.Accounts
{
    /// <summary>
    /// Creates <see cref="IAccount"/>s.
    /// </summary>
    public abstract class AccountFactory : IAccountFactory
    {
        /// <summary>
        /// Holds the <see cref="IEmailAddressGeneratorFactory"/> to be used.
        /// </summary>
        protected readonly IEmailAddressGeneratorFactory _emailAddressGeneratorFactory;

        /// <summary>
        /// Holds the domain to be used.
        /// </summary>
        protected readonly string _domain;

        /// <summary>
        /// Creates a new <see cref="AccountFactory"/> instance.
        /// </summary>
        /// <param name="emailAddressGeneratorFactory">The <see cref="IEmailAddressGeneratorFactory"/> to be used.</param>
        /// <param name="domain">The domain to be used.</param>
        protected AccountFactory(IEmailAddressGeneratorFactory emailAddressGeneratorFactory, string domain)
        {
            _emailAddressGeneratorFactory = emailAddressGeneratorFactory;
            _domain = domain;
        }

        /// <inheritdoc />
        public IAccount CreateStaffAccount(Person person)
        {
            var account = CreateBaseStaffAccount(person);
            account.EmailAddress = GenerateEmailAddress(account);

            return account;
        }

        /// <inheritdoc />
        public IAccount CreateStudentAccount(Person person)
        {
            var account = CreateBaseStudentAccount(person);
            account.EmailAddress = GenerateEmailAddress(account);

            return account;
        }

        /// <summary>
        /// Create a base <see cref="IAccount"/> for the given <param name="person"></param>
        /// with type of <see cref="AccountType.Staff"/>.
        /// </summary>
        /// <param name="person">The <see cref="Person"/> to create an <see cref="IAccount"/> for.</param>
        /// <returns>An <see cref="IAccount"/> of type <see cref="AccountType.Staff"/>.</returns>
        private IAccount CreateBaseStaffAccount(Person person)
            => new Account(AccountType.Staff, person)
        ;

        /// <summary>
        /// Create a base <see cref="IAccount"/> for the given <param name="person"></param>
        /// with type of <see cref="AccountType.Student"/>.
        /// </summary>
        /// <param name="person">The <see cref="Person"/> to create an <see cref="IAccount"/> for.</param>
        /// <returns>An <see cref="IAccount"/> of type <see cref="AccountType.Student"/>.</returns>
        private IAccount CreateBaseStudentAccount(Person person)
            => new Account(AccountType.Student, person)
        ;

        /// <summary>
        /// Generates an e-mail address for a given <see cref="IAccount"/>.
        /// </summary>
        /// <param name="account">The account to calculate an e-mail address for.</param>
        /// <returns>An e-mail address.</returns>
        private string GenerateEmailAddress(IAccount account)
            => _emailAddressGeneratorFactory
                .GetEmailAddressGenerator(account)
                .GenerateEmailAddress(account, _domain)
        ;
    }
}
