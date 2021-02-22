using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace school.Models
{
    public class student
    {
        public student()
        {
        }

        public student(int id, string name, int age, int numberStudent, string adress, long phone, int year, Classroom classroom, Material material)
        {
            Id = id;
            Name = name;
            Age = age;
            NumberStudent = numberStudent;
            Adress = adress;
            Phone = phone;
            Year = year;
            this.classroom = classroom;
            this.material = material;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberStudent { get; set; }
        public string Adress { get; set; }
        public long Phone { get; set; }
        public int Year { get; set; }
        public Classroom classroom { get; set; }
        public Material material { get; set; }
    }
}
