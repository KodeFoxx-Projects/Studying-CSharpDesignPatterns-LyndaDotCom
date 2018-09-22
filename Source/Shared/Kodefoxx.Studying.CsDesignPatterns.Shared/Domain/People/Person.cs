using System.Diagnostics;

namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.People
{
    /// <summary>
    /// Represents a person.
    /// </summary>
    [DebuggerDisplay("{Id:00000} | {FirstName} {LastName}")]
    public class Person
    {
        /// <summary>
        /// The person's unique identifier.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// The person's first name.
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// The person's last name.
        /// </summary>
        public string LastName { get; }

        /// <summary>
        /// Creates a new <see cref="Person"/> instance.
        /// </summary>
        /// <param name="id">The person's unique identifier.</param>
        /// <param name="firstName">The person's first name.</param>
        /// <param name="lastName">The person's last name.</param>
        public Person(long id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        /// <inheritdoc />
        public override string ToString()
            => $"{Id:00000} | {FirstName} {LastName}"
        ;
    }
}
