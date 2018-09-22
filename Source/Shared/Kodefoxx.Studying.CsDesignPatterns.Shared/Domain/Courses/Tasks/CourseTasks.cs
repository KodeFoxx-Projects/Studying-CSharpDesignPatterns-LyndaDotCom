using System;
using System.Collections.Generic;
using System.Linq;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Accounts;
using Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.People;

namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Domain.Courses.Tasks
{
    /// <summary>
    /// Keeps track of <see cref="CourseTask"/>s.
    /// </summary>
    public sealed class CourseTasks : Infrastructure.Observer.IObservable<CourseTask, Account>
    {
        /// <summary>
        /// Holds track of all the <see cref="CourseTask"/>s.
        /// </summary>
        private readonly List<CourseTask> _courseTasks
            = new List<CourseTask>()
        ;

        /// <summary>
        /// Holds track of all the <see cref="Account"/>s.
        /// </summary>
        private readonly Dictionary<string, Account> _observers
            = new Dictionary<string, Account>()
        ;

        /// <summary>
        /// Gets the tasks for this course.
        /// </summary>
        public IEnumerable<CourseTask> Tasks
            => _courseTasks.AsReadOnly()
        ;

        public void AddTask(string description, DateTime dueDate)
        {            
            _courseTasks.Add(new CourseTask(description, dueDate));
            Notify(_courseTasks.Last());
        }

        /// <inheritdoc />
        public void Notify(CourseTask observable)
            => _observers
                .Values
                .ToList()
                .ForEach(o => o.Update(observable))
        ;

        /// <inheritdoc />
        public void AddObserver(Account observer)
        {
            if (!_observers.ContainsKey(observer.Id))
                _observers.Add(observer.Id, observer);
        }            

        /// <inheritdoc />
        public void RemoveObserver(Account observer)
        {
            if (_observers.ContainsKey(observer.Id))
                _observers.Remove(observer.Id);
        }
    }
}
