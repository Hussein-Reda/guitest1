using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS101
{
    class EventsFeed
    {
        private List<Event> eventsFeed;

        public EventsFeed()
        {
            eventsFeed = new List<Event>();
        }

        public bool addEvent(Event e)
        {
            eventsFeed.Add(e);
            return true ;
        }
    }
}
