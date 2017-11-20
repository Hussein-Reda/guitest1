using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS101
{
    class Event
    {
        private int id;
        private DateTime date;
        private string name;
        private string decription;

        public Event(int id, DateTime date, string name, string decription)
        {
            this.id = id;
            this.date = date;
            this.name = name;
            this.decription = decription;
        }

        public override string ToString()
        {
            return id+"/"+date+"/"+name+"/"+decription;
        }

    }
}
