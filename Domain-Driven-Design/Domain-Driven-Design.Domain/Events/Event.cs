using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Driven_Design.Domain.Events
{
    public abstract class Event
    {
        public DateTime OccurredOn { get; }

        protected Event()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}
