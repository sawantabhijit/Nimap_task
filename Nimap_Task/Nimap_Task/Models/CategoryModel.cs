﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nimap_Task.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}