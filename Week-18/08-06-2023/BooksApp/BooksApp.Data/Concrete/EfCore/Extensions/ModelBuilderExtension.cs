using BooksApp.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Concrete.EfCore.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            #region Role Bilgileri
            List<Role> roles = new List<Role>
            {
                new Role { Name = "Admin", Description = "Y�neticilerin rol� bu.", NormalizedName = "ADMIN" },
                new Role { Name= "User", Description = "Di�er t�m kullan�c�lar�n rol� bu.", NormalizedName = "USER"}
            };
            modelBuilder.Entity<Role>().HasData(roles);
            #endregion

            #region Kullan�c� Bilgileri
            List<User> users = new List<User>
            {
                new User
                {

                    FirstName ="Deniz",
                    LastName = "Fo�a",
                    UserName = "deniz",
                    NormalizedUserName = "DENIZ",
                    Email = "denizfoca@gmail.com",
                    NormalizedEmail = "DENIZFOCA@GMAIL.COM",
                    Gender = "Kad�n",
                    DateOfBirth = new DateTime(1985,7,12),
                    Address = "Kemal Pa�a Mahallesi Z�ht� Bey Sokak No:12 Daire:3 �sk�dar",
                    City = "�stanbul",
                    EmailConfirmed = true,
                    SecurityStamp = "XXXY"
                },
                new User
                {
                    FirstName ="Murat",
                    LastName = "Kendirli",
                    UserName = "murat",
                    NormalizedUserName = "MURAT",
                    Email = "muratkendirli@gmail.com",
                    NormalizedEmail = "MURATKENDIRLI@GMAIL.COM",
                    Gender = "Kad�n",
                    DateOfBirth = new DateTime(1983,9,10),
                    Address = "Barbaros Bulvar� Z�ht� Bey Sokak No:5 Daire:23 Be�ikta�",
                    City = "�stanbul",
                    EmailConfirmed = true,
                    SecurityStamp = "XXXX"
                }
            };
            modelBuilder.Entity<User>().HasData(users);
            #endregion

            #region �ifre ��lemleri
            var passwordHasher = new PasswordHasher<User>(); //�ifreyi hashleyebilme imkan� verdi.
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Qwe123.");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");

            #endregion

            #region Rol Atama ��lemleri
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string> { UserId = users[0].Id, RoleId = roles[0].Id },
                new IdentityUserRole<string> { UserId = users[1].Id, RoleId = roles[1].Id }

            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            #endregion

            #region Al��veri� Sepeti ��lemleri

            #endregion
        }
    }
}
