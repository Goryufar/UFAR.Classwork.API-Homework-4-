using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFAR.Classwork.Data.Entities
{
    public record BaseEntity
    {
        // This is a public required property
        // This property is of type int
        // Required properties are properties that must be set when creating an object
        // Required added in C# 9.0 and later versions of C# 
        public required int Id { get; set; }

        public required bool isDeleted { get; set; }
    }
}
