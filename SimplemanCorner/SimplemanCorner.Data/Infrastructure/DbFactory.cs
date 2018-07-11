namespace SimplemanCorner.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private SimplemanCornerDbContext dbContext;

        public SimplemanCornerDbContext Init()
        {
            return dbContext ?? (dbContext = new SimplemanCornerDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}