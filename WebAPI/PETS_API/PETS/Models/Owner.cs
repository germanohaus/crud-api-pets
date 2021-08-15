using System;
using System.Collections.Generic;

namespace PETS.Models
{
    public partial class Owner
    {
        public Owner()
        {
            Cats = new HashSet<Cats>();
            Dogs = new HashSet<Dogs>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Cats> Cats { get; set; }
        public virtual ICollection<Dogs> Dogs { get; set; }
    }
}
