using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public static class SeedData
{
    public static void Seed(IApplicationBuilder app)
    {
        MuzikContext context =
            app.ApplicationServices.GetRequiredService<MuzikContext>();
        context.Database.Migrate();
    }
}