using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArch.Domain.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [MaxLength(150)]
        [Required(ErrorMessage = "Please Enter field of Name")]
        public string Name { get; set; }
        [MaxLength(4500)]
        [Required(ErrorMessage = "Please Enter field of Description")]
        public string Description { get; set; }
        [MaxLength(650)]
        [Required(ErrorMessage = "Please Select an Image")]
        public string ImageUrl { get; set; }


    }
}
