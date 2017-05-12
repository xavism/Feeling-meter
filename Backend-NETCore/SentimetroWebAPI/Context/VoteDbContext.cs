using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SentimetroWebAPI.Entities;

namespace SentimetroWebAPI.Context
{
    public class VoteDbContext : DbContext
    {
        public VoteDbContext(DbContextOptions<VoteDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Vote> Votes { get; set; }
    }
}
