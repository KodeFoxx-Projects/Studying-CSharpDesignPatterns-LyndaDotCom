using Kodefoxx.Studying.CsDesignPatterns.FactoryMethod.EmailAddressGenerator;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain;

namespace Kodefoxxx.Studying.CsDesignPatterns.AbstractFacto.Accounts
{
    /// <summary>
    /// Creates <see cref="IAccount"/>s for "School".
    /// </summary>
    public sealed class SchoolAccountFactory : AccountFactory
    {
        public SchoolAccountFactory(IEmailAddressGeneratorFactory emailAddressGeneratorFactory)
            : base(
                emailAddressGeneratorFactory, 
                "school.edu"
            )
        { }
    }    
}
