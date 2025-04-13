﻿namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}