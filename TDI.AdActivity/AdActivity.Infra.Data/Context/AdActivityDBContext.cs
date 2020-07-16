using AdActivity.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdActivity.Infra.Data.Context
{
    public class AdActivityDBContext : DbContext
    {
        public AdActivityDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<FundingType> FundingTypes { get; set; }

    }
}
