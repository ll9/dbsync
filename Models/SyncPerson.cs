using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class SyncPerson: Person
    {

        public SyncPerson(string name, int age, string projectName)
        {
            Name = name;
            Age = age;
            ProjectName = projectName;

            GUID = Guid.NewGuid().ToString();
            LastSynced = DateTime.MinValue;
            Deleted = false;
            IsSynced = false;
        }

        public SyncPerson(string gUID, string name, int age, string projectName, DateTime lastSynced, bool deleted, bool isSynced)
        {
            GUID = gUID;
            Name = name;
            Age = age;
            ProjectName = projectName;
            LastSynced = lastSynced;
            Deleted = deleted;
            IsSynced = isSynced;
        }

        public SyncPerson(bool isSynced)
        {
            IsSynced = isSynced;
        }

        public SyncPerson()
        {

        }

        public bool IsSynced { get; set; }

        public override string ToString()
        {
            var properties = typeof(SyncPerson).GetProperties();
            var result = "";

            foreach (var prop in properties)
            {
                result += $"{prop.Name}: {prop.GetValue(this)}\n";
            }

            return result;
        }
    }
}
