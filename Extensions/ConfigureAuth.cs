using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace DotNetCore_MVC.Extensions
{
    public static class ConfigureAuth
    {
        public static void ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            IConfigurationSection appConfiguration = configuration.GetSection("AppConfiguration");
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                byte[] key = Encoding.UTF8.GetBytes(appConfiguration["TokenKey"] ?? string.Empty);
                o.SaveToken = true;
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ValidAudiences = new List<string>() { appConfiguration["Audiences"] ?? string.Empty },
                    ValidIssuers = new List<string>() { appConfiguration["Issuers"] ?? string.Empty },
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                };
            });
        }
    }
}
