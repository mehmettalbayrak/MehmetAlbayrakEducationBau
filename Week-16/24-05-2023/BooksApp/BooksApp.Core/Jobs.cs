﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BooksApp.Core.Models;
using Microsoft.AspNetCore.Http;

namespace BooksApp.Core
{
    public static class Jobs
    {
        public static string GetUrl(string text)
        {
            #region Açıklamalar
            /*
             * Bu metot kendisine gönderilen url bilgisinin içindeki;
             * 1) Latin alfabesine çevrilirken sorun yaratma ihtimali bulunan ı, İ gibi harfleri dönüştürecek.
             * Diğer Türkçe karakterlerin yerine latin alfabesindeki karşılık gelen küçük harflerini koyacak ö->o, ş->s gibi
             * Boşlukların yerine - işareti koyaacak
             * Nokta(.), slash(/), noktalı virgül(;) gibi karakterleri de yok edecek.
             */
            #endregion
            #region Sorunlu Türkçe Karakterler Küçük Harfe Dönüştürülüyor
            text = text.Replace("I", "i");
            text = text.Replace("İ", "i");
            text = text.Replace("ı", "i");
            #endregion
            #region Diğerleri Küçük Harfe Dönüşütürülüyor
            text = text.ToLower();
            #endregion
            #region Türkçe Karakterler Latin Karakterlerine Dönüştürülüyor
            text = text.Replace("ö", "o");
            text = text.Replace("ü", "u");
            text = text.Replace("ş", "s");
            text = text.Replace("ç", "c");
            text = text.Replace("ğ", "g");
            #endregion
            #region Boşluklar Tireye Dönüştürülüyor
            text = text.Replace(" ", "-");
            #endregion
            #region Sorunlu Karakterler Kaldırılıyor
            text = text.Replace(".", "");
            text = text.Replace(",", "");
            text = text.Replace("/", "");
            text = text.Replace("\\", "");
            text = text.Replace("'", "");
            text = text.Replace("\"", "");
            text = text.Replace("^", "");
            text = text.Replace("#", "");
            text = text.Replace("$", "");
            text = text.Replace("%", "");
            text = text.Replace("&", "");
            text = text.Replace("{", "");
            text = text.Replace("(", "");
            text = text.Replace("[", "");
            text = text.Replace("]", "");
            text = text.Replace(")", "");
            text = text.Replace("}", "");
            text = text.Replace("*", "");
            text = text.Replace("=", "");
            text = text.Replace("?", "");
            text = text.Replace("_", "-");
            text = text.Replace("~", "");
            text = text.Replace("`", "");
            text = text.Replace("!", "");
            text = text.Replace("@", "");
            text = text.Replace(">", "");
            text = text.Replace("<", "");
            text = text.Replace("|", "");
            text = text.Replace("€", "");
            text = text.Replace("+", "");
            #endregion
            return text;
        }
        public static string CutText(string text, int length)
        {
            return text.Substring(0, text.Length < length ? text.Length : 30);
        }
        public static List<int> GetYears()
        {
            int year = DateTime.Now.Year;
            int maxYear = year - 18;
            int minYear = 0;
            List<int> years = new List<int>();
            for (int i = minYear; i <= maxYear; i++)
            {
                years.Add(i);
            }
            return years;
        }
        public static List<CityType> GetCities()
        {
            using (StreamReader sr = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/json/cities.json")))
            {
                string jsonResult = sr.ReadToEnd();
                List<CityType> cities = JsonSerializer.Deserialize<List<CityType>>(jsonResult);
                return cities;
            }
        }
        public static string UploadImage(IFormFile imageFile, string url, string dir)
        {
            //resim dosyası(imageFile)
            //url, klasrör(dir)
            //ilk işimiz gelen IFormFile içinden uzantıyı alıyoruz.
            var extension = Path.GetExtension(imageFile.FileName);

            //ikinci olarak rastgele bir dosya adı üretiyoruz.
            //kemal-tahir-54353-hgfdhs-4re245.jpg gibi.
            //url=safa-kunduraci
            //guid=4325-54523452-543254
            //extension=.jpg
            //safa-kunduraci-4325-54523452-543254.jpg oluşacak
            var randomName = $"{url}-{Guid.NewGuid()}.{extension}";

            //şimdi ise resmi kaydedeceğimiz yolu belirliyoruz yani path.
            var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot", "images", dir, randomName);

            //resmi bir stram(akış) nesnesinin içine koymamız gerekiyor. Ve sonra bu nesne üzerinden resmi sunucuya kopyalayacağız.

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                imageFile.CopyTo(stream);
            }

            return randomName;
        }


    }
}
