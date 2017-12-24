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
            var bodies = await _ctx.Posts.Include(p => p.Comments).Select(p => p.Body).ToListAsync();
            return bodies.FirstOrDefault() ?? string.Empty;
        }
    }
}
