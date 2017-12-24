using System;

namespace Tests.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Body { get; set; }

        public Guid Post { get; set; }
    }
}
