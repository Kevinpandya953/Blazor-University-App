﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BlazorApp2.Models
{
    public partial class Course
    {
        public Course()
        {
            ProgramCourse = new HashSet<ProgramCourse>();
            SemesterCourse = new HashSet<SemesterCourse>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseCredit { get; set; }

        public virtual ICollection<ProgramCourse> ProgramCourse { get; set; }
        public virtual ICollection<SemesterCourse> SemesterCourse { get; set; }
    }
}