using System.Collections.Generic;
using System.Linq;

namespace ShieldTech.Validations.Validations
{
    public class Validator : IValidator
    {
        private readonly IList<Validation> _notifications;

        public Validator()
        {
            _notifications = new List<Validation>();
        }

        public void Add(Validation validation)
        {
            _notifications.Add(validation);
        }
        
        public void Add(string name, string value)
        {
            _notifications.Add(new Validation(name, value));
        }

        public bool IsValid => !_notifications.Any();
        public bool IsInvalid => _notifications.Any();
        public IList<Validation> Notifications => _notifications.ToList().AsReadOnly();
    }
}