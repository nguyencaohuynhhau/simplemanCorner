using System;

namespace SimplemanCorner.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        SimplemanCornerDbContext Init();
    }
}