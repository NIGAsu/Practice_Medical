using Medical.Persistence.EntityTypeContext;

namespace Medical.Persistence
{
    public static class Initializer
    {
        public static async Task Initialize(DoctorDbContext context)
        {
            _ = await context.Database.EnsureDeletedAsync();
            _ = await context.Database.EnsureCreatedAsync();
        }
       
    }
}
//I think this not really cool,i'am about Async Deleted.Of course it's just for testing.