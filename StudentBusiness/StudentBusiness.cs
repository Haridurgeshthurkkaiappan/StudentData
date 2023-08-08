using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary.SrudentModel;


namespace StudentLibrary.StudentBusiness
{
   public class StudentDataBusiness
    {
        public StudentDataModel StudentDatainfo()
        {
            StudentDataModel std = new StudentDataModel();


            std.StudentName = Console.ReadLine();
            std.SubjectName = Console.ReadLine();
            std.SubjectMark = Convert.ToInt32(Console.ReadLine());
           

            return std;
        }

    }
}
