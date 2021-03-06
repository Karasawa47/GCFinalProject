﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace GCFinalProject.Models
{
    public class Comment
    {
        
        public int CommentID { get; set; }
        public int EventID { get; set; }
        public DateTime Date { get; set; }
        [Display(Name = "Comments")] 
        public string CommentText { get; set; }
        
    }
}