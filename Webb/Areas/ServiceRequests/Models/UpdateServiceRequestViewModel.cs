using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webb.Areas.ServiceRequests.Models
{
    public class UpdateServiceRequestViewModel:NewServiceRequestViewModel
    {
        public string RowKey { get; set; }
        public string PartitionKey { get; set; }
        [Required]
        [Display(Name = "Service Engineer")]
        public string ServiceEngineer { get; set; }
        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}
