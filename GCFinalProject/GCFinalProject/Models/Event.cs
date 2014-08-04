using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GCFinalProject.Models
{
    public class Event
    {
        public int EventID { get; set; }
        [Display(Name = "Event Description")]
        public string EventDesc { get; set; }
        [Display(Name="Event Name")]
        public string EventName { get; set; }
        [Display(Name = "Start Date and Time")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date and Time")]
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        [Display(Name = "Event Contact")]
        public string ContactInfo { get; set; }
        [Display(Name = "Link URL")]
        public string LinkUrl { get; set; }
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }
        public int CategoryID { get; set; }
        public string Location { get; set; }
        [Display(Name = "Short Description")]
        public string  ShortSummary { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}