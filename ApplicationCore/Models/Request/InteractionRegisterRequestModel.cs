using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Request
{
    public class InteractionRegisterRequestModel
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }

        public int? ClientId { get; set; }
        public DateTime? IntDate { get; set; }
        public string? Remarks { get; set; }
    }
}
