using System;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace SmartHomeDbProject.Models
{
    public class AuthService : IAuthService
    {
        private readonly SmartHomeDbContext _context;
        private readonly JwtSettings _jwtSettings;

        public AuthService(SmartHomeDbContext context, IOptions<JwtSettings> jwtSettings)
        {
            _context = context;
            _jwtSettings = jwtSettings.Value;
        }

        public async Task<string> Authenticate(string username, string password)
        {
            var user = _context.Users.Where(x => x.UserName.Equals(username) && x.Password.Equals(password)).FirstOrDefault();

            if (user == null) // Use hashed passwords in production
            {
                return null;
            }

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                expires: DateTime.Now.AddMinutes(_jwtSettings.ExpirationMinutes),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<bool> Register(string username, string password)
        {
            // check if user already exists
            var existingUser = _context.Users.FirstOrDefault(u => u.UserName == username);
            if (existingUser != null) return false;

            var newUser = new Users
            {
                UserName = username,
                Password = password // ⚠️ Hash before saving in real projects
            };

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
