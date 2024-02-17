using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfilionStudentManagement.DAL.Models
{
    public class TblStudents
    {
        public TblStudents() { }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? Age { get; set; } = 0;
        public string Class { get; set; } = string.Empty;
    }

}
