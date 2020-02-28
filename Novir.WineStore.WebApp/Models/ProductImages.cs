﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Novir.WineStore.WebApp.Models
{
    public class ProductImages
    {
        [Key]
        public int Id { get; set; }
        public string Path { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
    }
}
