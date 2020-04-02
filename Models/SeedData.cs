using aspstarter.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspstarter.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)

        {

            using var context = new MvcSongContext(serviceProvider.

                GetRequiredService<DbContextOptions<MvcSongContext>>());



            if (context.Song.Any())
            {
                return;     //songs in the db. Don't do anything We are good to go 
            }

            context.Song.AddRange(
                new Song
                {
                    title = "some title",
                    release = DateTime.Parse("2020-3-26")
                });
            context.SaveChanges();
        }
    }
}
