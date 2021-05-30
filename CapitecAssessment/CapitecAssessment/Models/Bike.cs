using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CapitecAssessment.Model
{
    public class Bike
    {

        [Required(ErrorMessage = "Model cannot be empty")]
        public string bike_Model { get; set; }
        public string bike_Description { get; set; }
        public string bike_Make { get; set; }
    }
}
