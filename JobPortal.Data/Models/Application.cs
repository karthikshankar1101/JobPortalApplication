using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Data.Models
{
    public class Application
    {
        public Guid Id { get; set; }
        public string ResumeUrl { get; set; }
        public Status ApplicationStatus { get; set; }
        public DateTime AppliedDate { get; set; }

        //Navigation Properties
        public int UserId { get; set; }
        public User User { get; set; }
        public Guid JobId { get; set; }
        public Job Job { get; set; }

    }

    public enum Status
    {
        Pending,
        Accepted,
        Rejected
    }
}
