using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Response
{
    public class InteractionResponseModel
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }

        public int? ClientId { get; set; }
        public DateTime? IntDate { get; set; }
        public string? Remarks { get; set; }
    }
}
