using CourseManagement.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public StudentType Type { get; set; }
    }
}
