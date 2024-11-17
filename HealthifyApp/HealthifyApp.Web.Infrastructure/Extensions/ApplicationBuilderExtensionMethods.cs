using HealthifyApp.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HealthifyApp.Web.Infrastructure.Extensions
{
    public static class ApplicationBuilderExtensionMethods
    {
        public static IApplicationBuilder ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope serviceScope = app.ApplicationServices.CreateScope();

            HealthifyDbContext dbContext = serviceScope
                .ServiceProvider
                .GetRequiredService<HealthifyDbContext>()!;
            dbContext.Database.Migrate();

            return app;
        }
    }
}
