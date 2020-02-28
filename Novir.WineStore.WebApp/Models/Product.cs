using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Novir.WineStore.WebApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MainImagePath { get; set; }
        public DateTime CreateDate { get; set; }

        [ForeignKey("Product")]
        public int CategoryId { get; set; }
        public List<ProductImages> ProductImages { get; set; }
    }
}
