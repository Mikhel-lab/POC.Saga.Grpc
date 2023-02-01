using Hr.Zeth.Poc.Infastructure.Data;
using Hr.Zeth.Poc.Shared.Entities;
using Onboarding.Zeth.Poc.Infastructure.Data;
using Onboarding.Zeth.Poc.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductGrpc.Data
{
    public class HRContextSeed
    {
        public static void SeedAsync(OnboardDbContext context)
        {
            if (!context.Onboards.Any())
            {
                var onb = new List<Onboard>
                {
                    new Onboard
                    {
                        RIN = "1",
                        Email = "mikel@gmail.com",
                    },
                    new Onboard
                    {
                       RIN = "1",
                       Email = "mikel@gmail.com",
                    }
                };
                context.Onboards.AddRange(onb);
                context.SaveChanges();
            }
        }
    }
}
