﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataVisual.Controls.TimeLine
{
    public class EventItem
    {
        public DateTime TimeStamp { get; set; }
        public bool IsImportantNode { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public EventItem(DateTime timeStamp, bool isImportant, string title, string detail)
        {
            TimeStamp = timeStamp;
            IsImportantNode = isImportant;
            Title = title;
            Detail = detail;
        }
    }
}
