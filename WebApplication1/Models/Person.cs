using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Column("nvarchar(50)")]
        public string FullName { get; set; }
        [Column("nvarchar(10)")]
        public int PhoneNumber { get; set; }

    }
}
