using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Rocky.Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
         
    }
}
