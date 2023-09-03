﻿using EventsApplication.Context;
using Microsoft.EntityFrameworkCore;

namespace Auth.Extensions
{
    public static class AddMigration
    {

        public static IApplicationBuilder ApplyMigration(this IApplicationBuilder app)
        {

            using (var scope = app.ApplicationServices.CreateScope())
            {
                var _db = scope.ServiceProvider.GetRequiredService<EventsDbContext>();
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }

            return app;
        }
    }
}
