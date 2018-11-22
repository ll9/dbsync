using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Person
    {
        public Person(string gUID, string name, int age, string projectName, DateTime lastSynced, bool deleted)
        {
            GUID = gUID;
            Name = name;
            Age = age;
            ProjectName = projectName;
            LastSynced = lastSynced;
            Deleted = deleted;
        }

        public Person()
        {

        }

        public Person(string name, int age, string projectName)
        {
            Name = name;
            Age = age;
            ProjectName = projectName;

            GUID = Guid.NewGuid().ToString();
            LastSynced = DateTime.MinValue;
            Deleted = false;
        }

        [Key]
        public string GUID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string ProjectName { get; set; }
        public DateTime LastSynced { get; set; }
        public bool Deleted { get; set; }
    }
}
