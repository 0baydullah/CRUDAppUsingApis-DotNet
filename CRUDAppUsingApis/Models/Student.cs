﻿
using System.ComponentModel.DataAnnotations;

namespace CRUDAppUsingApis.Models
{
    public class Student
    {
        public int id { get; set; }
        [Required]
        public string studentName { get; set; }
        [Required]
        public string studentGender { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public int standard { get; set; }
    }
}
