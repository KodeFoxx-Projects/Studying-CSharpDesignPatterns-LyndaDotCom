using System.IO;
using System.Linq;
using Kodefoxx.Studying.CsDesignPatterns.FactoryMethod.EmailAddressGenerator;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Infrastructure.ConsoleDemo;
using Kodefoxxx.Studying.CsDesignPatterns.AbstractFacto.Accounts;
using Microsoft.Extensions.DependencyInjection;

namespace Kodefoxxx.Studying.CsDesignPatterns.AbstractFacto
{
    /// <summary>
    /// Demo showcasing the Abstract Factory.
    /// </summary>
    public sealed class AbstractFactoryDemo : Demo
    {
        /// <summary>
        /// Creates a new <see cref="AbstractFactoryDemo"/> instance.
        /// </summary>
        public AbstractFactoryDemo() 
            : base("Abstract Factory", null)
        { }

        /// <inheritdoc />        
        public override void Run(TextWriter log)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IEmailAddressGeneratorFactory, DefaultEmailAddressGeneratorFactory>()
                .AddTransient<IAccountFactory, SchoolAccountFactory>()
                .BuildServiceProvider()
            ;

            var person = new Person(19851011L, "Yves", "Schelpe");

            var accountFactory = serviceProvider.GetService<IAccountFactory>();
            var accounts = new IAccount[] {
                accountFactory.CreateStaffAccount(person),
                accountFactory.CreateStudentAccount(person)
            }.ToList();

            accounts.ForEach(account =>
            {
                log.WriteLine($"For account '{account}':");
                log.WriteLine($" '{account.EmailAddress}'");
            });
        }
    }
}
