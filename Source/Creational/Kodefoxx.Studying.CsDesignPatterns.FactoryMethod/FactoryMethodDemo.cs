using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Kodefoxx.Studying.CsDesignPatterns.FactoryMethod.EmailAddressGenerator;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Infrastructure.ConsoleDemo;
using Microsoft.Extensions.DependencyInjection;

namespace Kodefoxx.Studying.CsDesignPatterns.FactoryMethod
{
    /// <summary>
    /// Demo showcasing the Factory Method.
    /// </summary>
    public sealed class FactoryMethodDemo : Demo
    {
        /// <summary>
        /// Creates a new <see cref="FactoryMethodDemo"/> instance.
        /// </summary>
        public FactoryMethodDemo()
            : base("Factory Method", null)
        { }

        /// <inheritdoc />
        public override void Run(TextWriter log)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IEmailAddressGeneratorFactory, DefaultEmailAddressGeneratorFactory>()
                .BuildServiceProvider()
            ;

            var person = new Person(19851011L, "Yves", "Schelpe");
            var accounts = new Account[] {
                new Account(AccountType.Staff, person),
                new Account(AccountType.Student, person),
            }.ToList();

            var emailAddressGeneratorFactory = serviceProvider.GetService<IEmailAddressGeneratorFactory>();
            accounts.Select(a => emailAddressGeneratorFactory
                .GetEmailAddressGenerator(a)
                .GenerateEmailAddress(a, "kdg.be")
            ).ToList().ForEach(log.WriteLine);
        }
    }
}
