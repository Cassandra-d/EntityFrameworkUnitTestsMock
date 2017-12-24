using EF;
using EntityFrameworkUnitTestsMock;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Tests
{
    public class ContextTests
    {
        [Test]
        public async Task Inclue()
        {
            var (b, p, c) = SetHelper.GetBasicData();
            var ctx = new Mock<Context>();

            ctx.Setup(_ => _.Blogs).Returns(b.Object);
            ctx.Setup(_ => _.Posts).Returns(p.Object);
            ctx.Setup(_ => _.Comments).Returns(c.Object);

            var svc = new Service(ctx.Object);

            var actual = await svc.UseInclude();

            Assert.NotNull(actual);
        }
    }
}
