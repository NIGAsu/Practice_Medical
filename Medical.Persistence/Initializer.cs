using Medical.Persistence.EntityTypeContext;

namespace Medical.Persistence
{
    static public class Initializer
    {
        static async public Task Initialize(DoctorDbContext context)
        {
            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();
        }
    }
}
//I think this not really cool,i'am about Async Deleted.