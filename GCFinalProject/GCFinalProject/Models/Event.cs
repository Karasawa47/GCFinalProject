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
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "End Time")]
        public DateTime? EndTime { get; set; }

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