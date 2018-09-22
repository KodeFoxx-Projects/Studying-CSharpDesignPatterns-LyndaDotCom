using Kodefoxx.Studying.CsDesignPatterns.FactoryMethod.EmailAddressGenerator;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain;

namespace Kodefoxxx.Studying.CsDesignPatterns.AbstractFacto.Accounts
{
    /// <summary>
    /// Creates <see cref="IAccount"/>s for "Company".
    /// </summary>
    public sealed class CompanyAccountFactory : AccountFactory
    {
        public CompanyAccountFactory(IEmailAddressGeneratorFactory emailAddressGeneratorFactory)
            : base(
                emailAddressGeneratorFactory,
                "company.com"
            )
        { }
    }
}
