using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class News
    {
        public int NewsID { get; set; }

        public string Title { get; set;}

        public int Description { get;set; }

        public DateTime Date { get; set; }

        public bool Status { get; set; }
    }
}
