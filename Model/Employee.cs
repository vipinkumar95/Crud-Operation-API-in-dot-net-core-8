﻿using System.ComponentModel.DataAnnotations;

namespace CrudOperationAPIwithAngular.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public string? Mobile {  get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }

        public bool status { get; set; }


    }
}