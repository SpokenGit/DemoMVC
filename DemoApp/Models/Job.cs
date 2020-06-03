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
        [Required]
        [MaxLength(100)]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }
        [Required]
        [MaxLength(200)]
        [Display(Name = "Job Description")]
        public string JobDescription { get; set; }
        [Display(Name="Creation Date")]
        [DisplayFormat(DataFormatString = "{0: MM/dd/yyyy}")]
        public DateTime? JobCreateAt { get; set; }
        [Display(Name="Expire Date")]
        public DateTime? JobExpiresAt { get; set; }
    }
}