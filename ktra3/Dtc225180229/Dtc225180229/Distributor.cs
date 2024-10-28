using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtc225180229
{
    internal class Distributor
    {
        [Key] public int idnpp { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int phone { get; set; }
        public string email { get; set; }
    }
}

