using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Data.Models
{
    public class Job
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public long Salary { get; set; }
        public DateTime PostedDate { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }

        public List<Application> Applications { get; set; }
    }
}
