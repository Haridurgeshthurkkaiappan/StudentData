using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.SrudentModel
{
   public class StudentDataModel
    {
        public int StudentID { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Required]
        public string SubjectName { get; set; }

        [Required]
        public int SubjectMark { get; set; }
     }

}
