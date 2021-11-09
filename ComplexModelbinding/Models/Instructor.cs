using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexModelbinding.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }
    }
}
