using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dtc225180314
{
    internal class Supplier
    {
        [Key] public int id {  get; set; }
        public string name { get; set; }    
        public int sdt { get; set; }
        public string email {  get; set; }
        public string daichi {  get; set; }
    }
}
