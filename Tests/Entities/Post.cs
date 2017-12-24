using System;
using System.Collections.Generic;

namespace Tests.Entities
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Body { get; set; }

        public Guid BlogId { get; set; }
        public Blog Blog { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
