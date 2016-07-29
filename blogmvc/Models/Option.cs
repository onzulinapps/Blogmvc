using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace blogmvc.Models
{
    public class Option
    {
        [Key]
        [Column("option_id")]
        public Int64 OptionID { get; set; }
        [Column("option_name")]
        public string OptionName { get; set; }
        [Column("option_value")]
        public string OptionValue { get; set; }
        [Column("autoload")]
        public string Autoload { get; set; }

    }
}
