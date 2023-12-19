using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace BloodDonation.Application.Configuration
{
    public static class Configuration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            //Fluent Validation
            services.AddFluentValidationAutoValidation();
            services.AddFluentValidationClientsideAdapters();
            return services;
        }
    }
}
