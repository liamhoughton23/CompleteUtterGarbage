﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CompleteUtterGarbage.Models
{
    public class Customer
    {
        [Key]
        public int PrimaryId { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Display(Name = "Vacation StartDate")]
        public string VacationStartDate { get; set; }

        [Display(Name = "Vacation EndDate")]
        public string VacationEndDate { get; set; }

        [Required]
        [Display(Name = "Pick Up Day")]
        public DayOfWeek PickUpDay { get; set; }
    }
}