using System;
using System.Collections.Generic;

namespace EF.Entities
{
    public class Post
    {
        public Post()
        {
            Comments = new List<Comment>();
        }

        public Guid Id { get; set; }
        public string Body { get; set; }

        public Guid BlogId { get; set; }
        public Blog Blog { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
