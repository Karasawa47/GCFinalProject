using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GCFinalProject.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string EventDesc { get; set; }
        public string EventName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public string ContactInfo { get; set; }
        public string LinkUrl { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryID { get; set; }
        public string Location { get; set; }
        public string  ShortSummary { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}