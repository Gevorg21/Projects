using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTask
{
  public  class User:EventArgs
    {
        public int ID { get; set; }
        public string FullName { get; set; }
    }
}
