﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManage.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [Required, StringLength(10000), Display(Name = "Description Student"), DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int Match { get; set; }
    }
}