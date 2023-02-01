using Microsoft.EntityFrameworkCore;
using Onboarding.Zeth.Poc.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onboarding.Zeth.Poc.Infastructure.Data
{
    public class OnboardDbContext: DbContext
    {
        public OnboardDbContext(DbContextOptions<OnboardDbContext> options) : base(options)
        {
        }

        public DbSet<Onboard> Onboards { get; set; }
    }
}

