using System;
using System.Diagnostics;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Courses.Tasks;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.People;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Infrastructure.Observer;

namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Accounts
{
    /// <summary>
    /// Represents an account.
    /// </summary>
    [DebuggerDisplay("{Id} | {Person.FirstName} {Person.LastName}")]
    public class Account : IAccount, Infrastructure.Observer.IObserver<CourseTask>
    {
        /// <summary>
        /// Keeps track of the action to be performed when an update arrives.
        /// </summary>
        private readonly Action<CourseTask, Account> _onUpdateAction;

        /// <inheritdoc cref="IAccount" />
        public string Id { get; }

        /// <inheritdoc cref="IAccount" />
        public AccountType Type { get; }

        /// <inheritdoc cref="IAccount" />
        public Person Person { get; }

        /// <inheritdoc cref="IAccount" />
        public string EmailAddress { get; set; }

        /// <summary>
        /// Creates a new <see cref="Account"/> instance.
        /// </summary>
        /// <param name="accountType">The type of account.</param>
        /// <param name="person">The person who's the owner of this account.</param>
        /// <param name="emailAddress">The (optional) e-mail address attached to this account.</param>
        /// <param name="onUpdateAction">The action to be performed when an update arrives</param>
        public Account(AccountType accountType, Person person, string emailAddress = null, Action<CourseTask, Account> onUpdateAction = null)
        {            
            Id = $"{accountType.ToString().ToUpper()}{person.Id}";
            Type = accountType;
            Person = person;
            EmailAddress = emailAddress;
            _onUpdateAction = onUpdateAction;
        }

        /// <inheritdoc cref="Infrastructure.Observer.IObserver{CourseTask}" />
        public void Update(CourseTask observable)
            => _onUpdateAction?.Invoke(observable, this)
        ;        

        /// <inheritdoc />
        public override string ToString()
            => $"{Id} | {Person.FirstName} {Person.LastName}"
        ;
    }
}
