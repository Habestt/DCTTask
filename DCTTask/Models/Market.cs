using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCTTask.Models
{
    internal class Market
    {
        public string coin_id { get; set; }        
        public string name { get; set; }
        public double converted_last { get; set; }
    }
}
