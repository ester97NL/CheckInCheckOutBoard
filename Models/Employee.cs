using System.ComponentModel.DataAnnotations;

namespace CheckInCheckOutBoard6.Models
{
    public class Employee
    {



        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public bool IsPresent { get; set; }

        public Employee()
        {
            this.ID = 1100;
        }

    }
}
