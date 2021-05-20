using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Client
    {
        public int Id { get; set; }

        public int? EmployeeId { get; set; }

        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public DateTime? AddedOn { get; set; }

        public Employee Employee { get; set; }

        //public ICollection<Interaction> Interactions { get; set; }

    }
}
