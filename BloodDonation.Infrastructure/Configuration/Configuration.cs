using BloodDonation.Domain.Interfaces;
using BloodDonation.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Infrastructure.Configuration
{
    public static class Configuration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configurations)
        {
            var connectionString = configurations.GetConnectionString("BloodDonation");
            services.AddDbContext<BloodDonationDbContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped<IBloodStorageRepository, BloodStorageRepository>();
            services.AddScoped<IDonationRepository, DonationRepository>();
            services.AddScoped<IDonorRepository, DonorRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
