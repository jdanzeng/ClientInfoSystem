using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Interaction
    {
        public int Id { get; set; }
        [Column(name:"EmplId")]
        public int? EmployeeId { get; set; }
        public int? ClientId { get; set; }

        public int? IntType { get; set; }
        public DateTime? IntDate { get; set; }
        public string? Remarks { get; set; }

        public Client Client { get; set; }
        public Employee Employee { get; set; }

    }
}
