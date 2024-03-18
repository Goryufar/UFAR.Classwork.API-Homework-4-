using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFAR.Classwork.Data.Entities
{
    // This class is a public record
    // use records when you want to create an immutable object
    // records are immutable by default
    // records are reference types
    // records are sealed by default
    public record LibraryEntity : BaseEntity
    {
        // This is a public property
        // This property is of type string
        // This property is a required property

        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Description { get; set; } = null!;

    }
}
