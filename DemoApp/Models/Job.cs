using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoApp.Models
{
    public class Job
    {

        public int Id { get; set; }
        [MaxLength(100)]
        public string JobTitle { get; set; }
        [MaxLength(200)]
        public string JobDescription { get; set; }
        [Display(Name="Creation Date")]
        public DateTime? JobCreateAt { get; set; }
        [Display(Name="Expire Date")]
        public DateTime? JobExpiresAt { get; set; }
    }
}