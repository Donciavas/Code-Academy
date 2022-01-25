using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sausio_24_d_pamoka
{
    public class TV_Show
    {
        public Guid ID { get; set; }
        public TimeSpan Duration { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }

        public TV_Show(Guid iD, DateTime duration, string title, string description, DateTime startTime)
        {
            ID = iD;
            Duration = duration;
            Title = title;
            Description = description;
            StartTime = startTime;
        }

        public TV_Show()
        {
        }
    }

}
