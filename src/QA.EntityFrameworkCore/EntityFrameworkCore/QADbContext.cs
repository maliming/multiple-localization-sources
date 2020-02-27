using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using QA.Authorization.Roles;
using QA.Authorization.Users;
using QA.MultiTenancy;

namespace QA.EntityFrameworkCore
{
    public class QADbContext : AbpZeroDbContext<Tenant, Role, User, QADbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public QADbContext(DbContextOptions<QADbContext> options)
            : base(options)
        {
        }
    }
}
