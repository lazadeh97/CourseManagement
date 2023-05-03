using CourseManagement.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.Models
{
    internal class Group
    {
        public string No { get; set; }
        public GroupCategory Category  { get; set; }
        public bool isOnline { get; set; }
        public GroupLimit Limit { get; set; }
        public Student Students { get; set; }
    }
}
