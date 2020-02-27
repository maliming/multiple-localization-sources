using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using QA.Configuration;
using QA.Web;

namespace QA.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class QADbContextFactory : IDesignTimeDbContextFactory<QADbContext>
    {
        public QADbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<QADbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            QADbContextConfigurer.Configure(builder, configuration.GetConnectionString(QAConsts.ConnectionStringName));

            return new QADbContext(builder.Options);
        }
    }
}
