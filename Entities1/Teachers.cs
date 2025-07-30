using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities1
{
    public class Teachers
    {
        public required string ID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Phone { get; set; }
        public required string MailAddress { get; set; }
    }
}
