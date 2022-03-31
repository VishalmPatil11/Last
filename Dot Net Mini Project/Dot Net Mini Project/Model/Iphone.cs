﻿using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;

namespace Dot_Net_Mini_Project
{
    class Iphone
    {
        [Key, ForeignKey("user")]
        //[Key]
        //[Required()]
        public int IphoneId { get; set; }

        [Required()]
        [MaxLength(10)]
        public string IphoneName { get; set; }

        //[Required()]
        //public string Category { get; set; }

        [Required()]
        public int Quantity { get; set; }

        [Required()]
        public decimal Price { get; set; }


        //[ForeignKey("UserId")]
        public virtual User user { get; set; }
    }
}