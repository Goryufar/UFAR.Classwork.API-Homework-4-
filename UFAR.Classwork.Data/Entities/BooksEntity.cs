using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFAR.Classwork.Data.Entities
{
    public record BooksEntity : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string Description { get; set; } = null!;
      
        public int LibraryId { get; set; }

    }

}
