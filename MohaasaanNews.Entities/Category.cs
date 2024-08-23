using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohaasaanNews.Entities
{
    public class Category : BaseEntity<byte>
    {
        public byte? ParentId { get; set; }
        public string Name { get; set; }
    }
}
