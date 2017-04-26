using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Data
{
    [Table("Log")]
    public class Log
    {

        [Key]
        public int LogId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }

    }
}
