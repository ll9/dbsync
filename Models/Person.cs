using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Person
    {
        [Key]
        public string GUID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string ProjectName { get; set; }
        public DateTime LastSynced { get; set; }
        public bool Deleted { get; set; }
    }
}
