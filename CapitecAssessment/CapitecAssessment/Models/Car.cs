using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CapitecAssessment.Models
{
    public class Car
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Model cannot be empty")]
        public string car_Model { get; set; }
        public string car_Description { get; set; }
        public string car_Make { get; set; }
    }
}
