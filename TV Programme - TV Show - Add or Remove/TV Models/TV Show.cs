﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_Programme___TV_Show___Add_or_Remove
{
    public class TV_Show
    {
        public Guid ID { get; set; }
        public int Duration { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string StartTime { get; set; }

        public TV_Show(int duration, string title, string description, string startTime)
        {
            ID = Guid.NewGuid();
            Duration = duration;
            Title = title;
            Description = description;
            StartTime = startTime;
        }
    }
}