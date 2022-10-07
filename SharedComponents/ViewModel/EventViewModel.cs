﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedComponents.ViewModel
{

    public class EventBaseViewModel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int EventCreatorId { get; set; }
    }

    public class EventViewModel : EventBaseViewModel
    {
        public int EventId { get; set; }
    }

    public class EventEditViewModel : EventBaseViewModel
    {
    }
}