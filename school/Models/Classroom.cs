using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace school.Models
{
    public class Classroom
    {
        public Classroom()
        {
        }

        public Classroom(int id, string name, List<student> students)
        {
            Id = id;
            Name = name;
            this.students = students;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<student> students { get; set; }
    }
}
