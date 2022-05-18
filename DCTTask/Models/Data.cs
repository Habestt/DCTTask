using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCTTask.Models
{
    internal class Data<TModel> where TModel : class
    {
        public ICollection<TModel> data { get; set; }        
    }
}
