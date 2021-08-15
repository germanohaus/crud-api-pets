using System;
using System.Collections.Generic;

namespace PETS.Models
{
    public partial class Cats
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public int Ownerid { get; set; }

        public virtual Owner Owner { get; set; }
    }
}
