using System;
using System.Collections.Generic;

namespace EF.Entities
{
    public class Blog
    {
        public Blog()
        {
            Posts = new List<Post>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
