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
                new Role { Id= "1", Name = "Admin", Description = "Yöneticilerin rolü bu.", NormalizedName = "ADMIN" },
                new Role { Id="2",Name= "User", Description = "Diðer tüm kullanýcýlarýn rolü bu.", NormalizedName = "USER"}
            };
            modelBuilder.Entity<Role>().HasData(roles);
            #endregion

            #region Kullanýcý Bilgileri
            List<User> users = new List<User>
            {
                new User
                {
                    Id = "1",
                    FirstName ="Deniz",
                    LastName = "Foça",
                    UserName = "deniz",
                    NormalizedUserName = "DENIZ",
                    Email = "denizfoca@gmail.com",
                    NormalizedEmail = "DENIZFOCA@GMAIL.COM",
                    Gender = "Kadýn",
                    DateOfBirth = new DateTime(1985,7,12),
                    Address = "Kemal Paþa Mahallesi Zühtü Bey Sokak No:12 Daire:3 Üsküdar",
                    City = "Ýstanbul",
                    EmailConfirmed = true,
                },
                new User
                {
                    Id = "2",
                    FirstName ="Murat",
                    LastName = "Kendirli",
                    UserName = "murat",
                    NormalizedUserName = "MURAT",
                    Email = "muratkendirli@gmail.com",
                    NormalizedEmail = "MURATKENDIRLI@GMAIL.COM",
                    Gender = "Kadýn",
                    DateOfBirth = new DateTime(1983,9,10),
                    Address = "Barbaros Bulvarý Zühtü Bey Sokak No:5 Daire:23 Beþiktaþ",
                    City = "Ýstanbul",
                    EmailConfirmed = true,
                }
            };
            modelBuilder.Entity<User>().HasData(users);
            #endregion

            #region Þifre Ýþlemleri
            var passwordHasher = new PasswordHasher<User>(); //þifreyi hashleyebilme imkaný verdi.
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Qwe123.");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");

            #endregion

            #region Rol Atama Ýþlemleri
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string> { UserId = "1", RoleId = "1" },
                new IdentityUserRole<string> { UserId = "2", RoleId = "2" }

            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            #endregion

            #region Alýþveriþ Sepeti Ýþlemleri

            #endregion
        }
    }
}
