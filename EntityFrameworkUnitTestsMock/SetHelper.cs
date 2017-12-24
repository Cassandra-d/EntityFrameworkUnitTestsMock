using EF.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace EntityFrameworkUnitTestsMock
{
    public static class SetHelper
    {
        public static (Mock<DbSet<Blog>> Blogs, Mock<DbSet<Post>> Posts, Mock<DbSet<Comment>> Comments) GetBasicData()
        {
            var blogs = new List<Blog>
            {
                new Blog { Id = Guid.NewGuid(), Title = "BBB" },
                new Blog { Id = Guid.NewGuid(), Title = "CCC" },
                new Blog { Id = Guid.NewGuid(), Title = "AAA" }
            };

            var posts = new List<Post>
            {
                new Post() { Id = Guid.NewGuid(), Body ="QWERTY" },
                new Post() { Id = Guid.NewGuid(), Body = "ASDFGH" },
                new Post() { Id = Guid.NewGuid(), Body = "ZXCVBN" }
            };

            var comments = new List<Comment>
            {
                new Comment() { Id = Guid.NewGuid(), Body = "1234" },
                new Comment() { Id = Guid.NewGuid(), Body = "5678" },
                new Comment() { Id = Guid.NewGuid(), Body = "90" }
            };

            var setBlog = new Mock<DbSet<Blog>>().SetupData(blogs);
            var setPost = new Mock<DbSet<Post>>().SetupData(posts);
            var setComment = new Mock<DbSet<Comment>>().SetupData(comments);

            return (setBlog, setPost, setComment);
        }
    }
}
