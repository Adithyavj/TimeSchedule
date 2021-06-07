using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class InterviewCall
    {
        public int Id { get; set; }
        public DateTime CallDate { get; set; }
        public string ContactedPerson { get; set; }
        public string PhoneNumber { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public bool IsShortListed { get; set; }
        public DateTime InterviewDate { get; set; }
        public string Remarks { get; set; }
    }
}
