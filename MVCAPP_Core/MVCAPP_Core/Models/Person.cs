using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAPP_Core.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirtDate { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string Cast { get; set; }
    }
}
