using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public DateTime PublishingDate { get; set; }
        public int Series { get; set; }
        public string Description { get; set; }
    }
}
