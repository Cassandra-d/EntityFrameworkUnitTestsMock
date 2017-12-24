using System.Threading.Tasks;
using System.Linq;
using System.Data.Entity;
using EF;

namespace Tests
{
    public class Service
    {
        private readonly Context _ctx;

        public Service(Context ctx)
        {
            _ctx = ctx ?? throw new System.ArgumentNullException(nameof(ctx));
        }
        public async Task<string> UseInclude()
        {
            var posts = await _ctx.Posts.Include(p => p.Comments).Include(p => p.Blog).ToListAsync();
            return posts.FirstOrDefault().Body ?? string.Empty;
        }
    }
}
