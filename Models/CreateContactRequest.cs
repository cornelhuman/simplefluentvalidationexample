using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidationFilterTest.Models
{
    public class CreateContactRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }
    }
}
