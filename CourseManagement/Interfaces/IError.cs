using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.Helpers
{
    internal interface IError
    {
        public string Message { get; set; }
    }
}
