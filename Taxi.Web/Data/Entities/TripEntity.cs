﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Taxi.Web.Data.Entities
{
    public class TripEntity
    {
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime StartDateLocal => StartDate.ToLocalTime();

        [DataType(DataType.DateTime)]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime? EndDate { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime? EndDateLocal => EndDate?.ToLocalTime();

        [MaxLength(100, ErrorMessage = "O campo {0} deve ter {1} caracteres????")]
        public string Source { get; set; }

        [MaxLength(100, ErrorMessage = "O campo {0} deve ter {1} caracteres????")]
        public string Target { get; set; }

        public float Qualification { get; set; }

        public double SourceLatitude { get; set; }

        public double SourceLongitude { get; set; }

        public double TargetLatitude { get; set; }

        public double TargetLongitude { get; set; }

        public string Remarks { get; set; }

        public TaxiEntity Taxi { get; set; }

        public ICollection<TripDetailEntity> TripDetails { get; set; }
    }
}