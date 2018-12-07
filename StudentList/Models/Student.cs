using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentList.Models
{
    public class Student
    {
   
        [Column(Order =0)]
        public int Id { get; set; }

        [Column("StudentName", Order = 1)]
        public string Name { get; set; }

        [Column(Order = 2)]
        public string FatherName { get; set; }

        [Column(Order = 3)]
        public string Class { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
       
    }
}
