﻿using BooksApp.Business.Abstract;
using BooksApp.Business.Concrete;
using BooksApp.Core;
using BooksApp.Entity.Concrete;
using BooksApp.MVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BooksApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorManager;

        public AuthorController(IAuthorService authorManager)
        {
            _authorManager = authorManager;
        }
        #region Listeleme
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Author> authorList = await _authorManager.GetAllAuthorsAsync(false);
            List<AuthorViewModel> authorViewModelList = authorList
                .Select(a => new AuthorViewModel
                {
                    Id = a.Id,
                    Name = a.FirstName + " " + a.LastName,
                    CreatedDate = a.CreatedDate,
                    ModifiedDate = a.ModifiedDate,
                    IsActive = a.IsActive,
                    Url = a.Url,
                    PhotoUrl = a.PhotoUrl,
                    BirthOfYear = a.BirthOfYear,
                    IsAlive=a.IsAlive
                }).ToList();
            return View(authorViewModelList);
        }
        #endregion
        #region Yeni Yazar
        [HttpGet]
        public IActionResult Create()
        {
            var years = Jobs.GetYears();
            AuthorAddViewModel authorAddViewModel = new AuthorAddViewModel{
                Years = years.Select(y=>new SelectListItem{
                    Text=y.ToString(),
                    Value=y.ToString()
                }).ToList()
            };
            return View(authorAddViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AuthorAddViewModel authorAddViewModel)
        {
            if (ModelState.IsValid)
            {
                string name = authorAddViewModel.FirstName + " " + authorAddViewModel.LastName;
                Author author = new Author
                {
                    FirstName = authorAddViewModel.FirstName,
                    LastName = authorAddViewModel.LastName,
                    About = authorAddViewModel.About,
                    IsActive = authorAddViewModel.IsActive,
                    BirthOfYear = authorAddViewModel.BirthOfYear,
                    Url = Jobs.GetUrl(name),
                    IsAlive=authorAddViewModel.IsAlive,
                    PhotoUrl = "default-profile.jpg"

                };
                await _authorManager.CreateWithUrl(author);
                return RedirectToAction("Index");
            }
            var years = Jobs.GetYears();
            authorAddViewModel.Years = years.Select(y => new SelectListItem
            {
                Text = y.ToString(),
                Value = y.ToString()
            }).ToList();
            return View(authorAddViewModel);
        }

        #endregion
        #region Yazar Güncelleme
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Author author = await _authorManager.GetByIdAsync(id);
            if (author == null)
            {
                return NotFound();
            }
            var years = Jobs.GetYears();
            AuthorEditViewModel authorEditViewModel = new AuthorEditViewModel
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                About = author.About,
                BirthOfYear = author.BirthOfYear,
                IsAlive = author.IsAlive,
                IsActive = author.IsActive,
                IsDeleted = author.IsDeleted,
                Years = years.Select(y => new SelectListItem
                {
                    Text = y.ToString(),
                    Value = y.ToString(),
                    Selected = author.BirthOfYear == y ? true : false
                }).ToList()
            };
            return View(authorEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(AuthorEditViewModel authorEditViewModel)
        {
            
            if (ModelState.IsValid)
            {
                Author author = await _authorManager.GetByIdAsync(authorEditViewModel.Id);
                author.FirstName = authorEditViewModel.FirstName;
                author.LastName = authorEditViewModel.LastName;
                author.About = authorEditViewModel.About;
                author.BirthOfYear = authorEditViewModel.BirthOfYear;
                author.IsActive = authorEditViewModel.IsActive;
                author.IsDeleted = authorEditViewModel.IsDeleted;
                author.IsAlive = authorEditViewModel.IsAlive;
                authorEditViewModel.Url = Jobs.GetUrl(authorEditViewModel.FirstName+"-"+authorEditViewModel.LastName);
                author.Url = authorEditViewModel.Url;
                author.ModifiedDate = DateTime.Now;
                
                _authorManager.Update(author);
                return RedirectToAction("Index"); 
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            Author author = await _authorManager.GetByIdAsync(id);
            if (author == null)
            {
                return NotFound();
            }
            author.IsActive = !author.IsActive;
            author.ModifiedDate = DateTime.Now;
            _authorManager.Update(author);
            return RedirectToAction("Index");
        }
        #endregion
        #region Yazar Kalıcı Silme
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Author author = await _authorManager.GetByIdAsync(id);
            if (author == null) return NotFound();
            AuthorDeleteViewModel authorDeleteViewModel = new AuthorDeleteViewModel
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                About = author.About,
                Url = author.Url,
                IsActive = author.IsActive,
                IsDeleted = author.IsDeleted,
                IsAlive = author.IsDeleted,
                CreatedDate = author.CreatedDate,
                ModifiedDate = author.ModifiedDate
            };
            return View(authorDeleteViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> HardDelete(int id)
        {
            Author author = await _authorManager.GetByIdAsync(id);
            if (author == null) return NotFound();
            _authorManager.Delete(author);
            return RedirectToAction("Index");
        }
        #endregion
        #region Yazar Soft Silme
        public async Task<IActionResult> SoftDelete(int id)
        {
            Author author = await _authorManager.GetByIdAsync(id);
            if (author == null)
            {
                return NotFound();
            }
            author.IsDeleted = true;
            author.ModifiedDate = DateTime.Now;
            _authorManager.Update(author);
            return RedirectToAction("Index");
        }
        #endregion
    }
}