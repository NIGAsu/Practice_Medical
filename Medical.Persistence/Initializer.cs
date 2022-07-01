using Medical.Persistence.EntityTypeContext;

namespace Medical.Persistence
{
    public static class Initializer
    {
        public static async Task Initialize(DataBaseContext context)
        {            
            _ = await context.Database.EnsureDeletedAsync();
            _ = await context.Database.EnsureCreatedAsync();
        }
    }
}