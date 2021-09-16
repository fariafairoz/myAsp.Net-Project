﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspDotNetProject.Models
{
    public class Product1
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public DateTime EntryDate { get; set; }
        
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        [NotMapped]
        public string CategoryName { get; set; }
    }
}