using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAssignment.Models
{
    public class Student
    {
        public int Id { get; set; }

        public int RegNumber { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

    }
}
