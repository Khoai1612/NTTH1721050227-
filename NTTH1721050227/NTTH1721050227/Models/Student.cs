﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTTH1721050227.Models
{
    public class Student :Person
    {
        [Key]
        [StringLength(50)]
        public string University { get; set; }

        [StringLength(50)]
        public string Address { get; set; }
    }
}