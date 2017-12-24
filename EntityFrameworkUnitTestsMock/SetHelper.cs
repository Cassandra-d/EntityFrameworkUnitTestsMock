using EF.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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
                new Post() { Id = Guid.NewGuid(), Body ="QWERTY", BlogId = blogs.ElementAt(0).Id, Blog = blogs.ElementAt(0)},
                new Post() { Id = Guid.NewGuid(), Body = "ASDFGH", BlogId = blogs.ElementAt(1).Id, Blog = blogs.ElementAt(1)},
                new Post() { Id = Guid.NewGuid(), Body = "ZXCVBN", BlogId = blogs.ElementAt(2).Id, Blog = blogs.ElementAt(2)}
            };

            var comments = new List<Comment>
            {
                new Comment() { Id = Guid.NewGuid(), Body = "1234", PostId = posts.ElementAt(0).Id, Post = posts.ElementAt(0) },
                new Comment() { Id = Guid.NewGuid(), Body = "5678", PostId = posts.ElementAt(1).Id, Post = posts.ElementAt(1) },
                new Comment() { Id = Guid.NewGuid(), Body = "90", PostId = posts.ElementAt(2).Id, Post = posts.ElementAt(2) }
            };

            var setBlog = new Mock<DbSet<Blog>>().SetupData(blogs);
            var setPost = new Mock<DbSet<Post>>().SetupData(posts);
            var setComment = new Mock<DbSet<Comment>>().SetupData(comments);

            return (setBlog, setPost, setComment);
        }
    }
}
