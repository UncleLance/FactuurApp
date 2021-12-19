using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactuurApp
{
    interface IMySqlObject
    {
        public int Id { get; set; }
        object Customer { get; set; }
    }
}
