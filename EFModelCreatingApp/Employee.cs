using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModelCreatingApp
{
    //[Table("Employees_Table")]
    //[Index("Phone", IsUnique = true, Name = "IX_Phone")]
    public class Employee
    {
        //int code;
        int age;

        //[Key]
        public int PassportNumber { set; get; }
        public string PassportSeries { set; get; }

        //[Column("FullName")]
        //[Required]
        public string? Name { set; get; }
        //[Column("AgeInt")]
        public int Age
        {
            get => age;
            set
            {
                if (value > 0 && value < 65)
                    age = value;
                else
                    throw new Exception("Incorrect age of employee");
            }
        }

        public string Phone { set; get; } = "";
        //[NotMapped]
        //public Position? Position { set; get; }
        //public Company? Company { set; get; }
    }

    public class Position
    {
        public int Id { set; get; }
        public string Name { set; get; } = "";

        //public Position()
        //{
        //    Console.WriteLine("Position default construct");
        //}

        public Position(string name)
        {
            Name = name;
            Console.WriteLine("Position parameters construct");
        }
    }

    //[NotMapped]
    public class Company
    {
        public int Id { set; get; }
        public string Name { set; get; } = "";
        public Country? Country { set; get; }
    }

    public class Country
    {
        public int Id { set; get; }
        public string Name { set; get; } = "";
    }
}
