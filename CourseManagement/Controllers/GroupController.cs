using CourseManagement.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.Controllers
{
    internal class GroupController:IError
    {
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public GroupController() 
        { 
            MenuController.ShowGroupDetailsMenu();
        }

        public void CreateNewGroup()
        {
            Message = "Your entered data is incorrect. Please try again! ";
        }
        public void GetListOfGroup()
        {

        }
        public void EditGroup() 
        { 

        }
    }
}
