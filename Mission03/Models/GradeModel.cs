using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission03.Models
{
    public class GradeModel
    {

        [Range(0, 100, ErrorMessage = "You must input a number between 1 and 100")]
        public int Asgmts { get; set; }
        [Range(0, 100, ErrorMessage = "You must input a number between 1 and 100")]
        public int Gp { get; set; }
        [Range(0, 100, ErrorMessage = "You must input a number between 1 and 100")]
        public int Qz { get; set; }
        [Range(0, 100, ErrorMessage = "You must input a number between 1 and 100")]
        public int Exm { get; set; }
        [Range(0, 100, ErrorMessage = "You must input a number between 1 and 100")]
        public int Ix { get; set; }


    }
}
