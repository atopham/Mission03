using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission03.Models
{
    public class GradeModel
    {
        [Required]
        [Range(0, 100, ErrorMessage = "You must input a number between 1 and 100")]
        public int asgmts { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "You must input a number between 1 and 100")]
        public int gp { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "You must input a number between 1 and 100")]
        public int qz { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "You must input a number between 1 and 100")]
        public int exm { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "You must input a number between 1 and 100")]
        public int ix { get; set; }


    }
}
