using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.Controllers
{
    internal class MenuController
    {
        public static string groupNumber { get; set; }
        public static char groupCategory { get; set; }
        public static char onlineType { get; set; }
        public static char userResponse { get; set; }

        public static void ShowGroupDetailsMenu()
        {
            Console.WriteLine("Enter Group Number: ");
            groupNumber = Console.ReadLine();

            Console.WriteLine("Enter Group Category: \n 1. Programming \n 2. Design \n 3. System Administration");
            groupCategory = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Group Type: \n 1. Offline \n 2. Online: ");
            onlineType = char.Parse(Console.ReadLine());
        }
        public static void ShowMainMenu()
        {
            Console.WriteLine("Please select an action below:\n");
            Console.WriteLine("1. Create new group");
            Console.WriteLine("2. Show list of groups");
            Console.WriteLine("3. Change selected group");
            Console.WriteLine("4. Show list of groups' students");
            Console.WriteLine("5. Show list of all students");
            Console.WriteLine("6. Create new student");
            Console.WriteLine("7. Delete some student \n ");

            userResponse = char.Parse(Console.ReadLine());
        }

    }
}
