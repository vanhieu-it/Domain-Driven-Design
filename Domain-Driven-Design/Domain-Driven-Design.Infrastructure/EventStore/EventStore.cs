using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Driven_Design.Domain.Events;

namespace Domain_Driven_Design.Infrastructure.EventStore
{
    public class EventStore
    {
        private readonly Dictionary<Guid, List<Event>> _store = new Dictionary<Guid, List<Event>>();

        public void SaveEvents(Guid aggregateId, IEnumerable<Event> events)
        {
            if (!_store.ContainsKey(aggregateId))
            {
                _store[aggregateId] = new List<Event>();
            }

            _store[aggregateId].AddRange(events);
        }

        public List<Event> GetEvents(Guid aggregateId)
        {
            if (_store.ContainsKey(aggregateId))
            {
                return _store[aggregateId];
            }

            return new List<Event>();
        }
    }
}
