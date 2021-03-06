using Microsoft.EntityFrameworkCore;

namespace MAVN.Persistence
{
    public interface IDbContextProvider
    {
        DbContext CreateDbContext();
    }
}