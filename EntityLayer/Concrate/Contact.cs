using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string ContactFromUserName { get; set; }
        public string ContactToEmail { get; set; }
        public string ContactSubject { get; set; }
        public string ContactContent { get; set; }
        public DateTime ContactDate { get; set; }
        public bool ContactStatus { get; set; }

    }
}
