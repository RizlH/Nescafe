using System.Security.Cryptography;
using Nescafe.Data;
using Nescafe.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Nescafe.Services
{
    public class AuthService
    {
        private readonly AppDbContext _db;
        public AuthService(AppDbContext db) => _db = db;

        public async Task<Member?> LoginAsync(string username, string password)
        {
            var user = await _db.Members.FirstOrDefaultAsync(x => x.Username == username && x.IsActive);
            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                return user;
            return null;
        }

        public async Task RegisterAsync(string username, string password, string fullname)
        {
            var hash = BCrypt.Net.BCrypt.HashPassword(password);
            var m = new Member
            {
                Username = username,
                PasswordHash = hash,
                FullName = fullname
            };
            _db.Members.Add(m);
            await _db.SaveChangesAsync();
        }

        public async Task RegisterAsync(string address, string cardId, string email, string fullname,
            string password, string phone, string phoneAlt, string referenceId, string username,
            string quest1, string quest2)
        {
            var hash = BCrypt.Net.BCrypt.HashPassword(password);
            var memberId = RandomNumberGenerator.GetString("1234567890", 4);
            var m = new Member
            {
                Username = username,
                PasswordHash = hash,
                FullName = fullname,
                Email = email,
                Address = address,
                Phone = phone,
                PhoneAlt = phoneAlt,
                IdCard = cardId,
                ReferenceId = referenceId,
                IsActive = true,
                level = "public",
                Status = "public",
                quest1 = quest1,
                quest2 = quest2,
                MemberId = memberId
            };
            _db.Members.Add(m);
            await _db.SaveChangesAsync();
        }

        public async Task<string> ResetPasswordAsync(string username, string quest1, string quest2)
        {
            var user = await _db.Members.FirstOrDefaultAsync(x => x.Username == username && x.IsActive && x.quest1 == quest1.Trim() && x.quest2 == quest2.Trim());
            if (user != null)
            {
                string password = RandomNumberGenerator.GetHexString(4, false);
                var hash = BCrypt.Net.BCrypt.HashPassword(password);
                user.PasswordHash = hash;
                _db.Update(user);
                await _db.SaveChangesAsync();
                return password;
            }
            return "";
        }
    }
}