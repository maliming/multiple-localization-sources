using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace QA.EntityFrameworkCore
{
    public static class QADbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<QADbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<QADbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
