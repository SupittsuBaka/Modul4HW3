﻿using System.Collections.Generic;

namespace ConsoleApp1.Entities
{
    public class Title
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
