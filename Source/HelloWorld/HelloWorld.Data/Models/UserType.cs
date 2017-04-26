using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Data
{
    public class UserType
    {
        public int UserTypeId { get; set; }
        public string UserTypeDescription { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedByUserName { get; set; }
    }
}
