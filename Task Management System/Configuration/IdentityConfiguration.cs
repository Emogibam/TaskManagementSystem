using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TaskManagementSystem.Infrastruture.Context;
using TaskManagementSystem.Infrastruture.Entities;

namespace Task_Management_System.Configuration
{
    public static class IdentityConfiguration
    {
        public static void ConfigureIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddIdentity<ApplicationUser, IdentityRole<Guid>>(x =>
            {
                // Password complexity requirements
                x.Password.RequireUppercase = true;
                x.Password.RequiredLength = 7;
                x.Password.RequireDigit = true;
                x.Password.RequireNonAlphanumeric = true; // Require special character

                // Account lockout settings
                x.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                x.Lockout.MaxFailedAccessAttempts = 5;

                // Two-Factor Authentication (2FA)
                x.Tokens.AuthenticatorTokenProvider = TokenOptions.DefaultAuthenticatorProvider;
                x.SignIn.RequireConfirmedPhoneNumber = false; // Set to true if you want to require phone number confirmation

                // Email confirmation
                x.Tokens.EmailConfirmationTokenProvider = TokenOptions.DefaultEmailProvider;
                x.SignIn.RequireConfirmedEmail = true;

                // User lockout threshold
                x.Lockout.MaxFailedAccessAttempts = 5; // Adjust as needed

                // User account deletion
                x.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();

            // Configure JWT authentication if needed
            var jwtSettings = configuration.GetSection("JWTSettings").Get<JwtSettings>();
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = true,
                    ValidateIssuer = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidAudience = jwtSettings.Audience,
                    ValidIssuer = jwtSettings.Issuer,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey)),
                    ClockSkew = TimeSpan.Zero
                };
            });
        }
    }
}
