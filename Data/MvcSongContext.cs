using aspstarter.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspstarter.Data
{
    public class MvcSongContext: DbContext
    {
        public MvcSongContext(DbContextOptions<MvcSongContext>options):base(options)
        { }
        public DbSet<Song> Song { get; set; }
    }
}
