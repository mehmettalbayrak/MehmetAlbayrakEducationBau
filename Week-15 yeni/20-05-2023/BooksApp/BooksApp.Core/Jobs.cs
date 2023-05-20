using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Core
{
    public static class Jobs
    {
        public static string GetUrl(string text)
        {
            #region Açýklamalar
            /*
             * Bu metot kendisine gönderilen url bilgisinin içindeki;
             * 1) Latin alfabesine çevrilirken sorun yaratma ihtimali bulunan ý, Ý gibi harfleri dönüþtürecek.
             * Diðer Türkçe karakterlerin yerine latin alfabesindeki karþýlýk gelen küçük harflerini koyacak ö->o, þ->s gibi
             * Boþluklarýn yerine - iþareti koyaacak
             * Nokta(.), slash(/), noktalý virgül(;) gibi karakterleri de yok edecek.
             */
            #endregion
            #region Sorunlu Türkçe Karakterler Küçük Harfe Dönüþtürülüyor
            text = text.Replace("I", "i");
            text = text.Replace("Ý", "i");
            text = text.Replace("ý", "i");
            #endregion
            #region Diðerleri Küçük Harfe Dönüþütürülüyor
            text = text.ToLower();
            #endregion
            #region Türkçe Karakterler Latin Karakterlerine Dönüþtürülüyor
            text = text.Replace("ö", "o");
            text = text.Replace("ü", "u");
            text = text.Replace("þ", "s");
            text = text.Replace("ç", "c");
            text = text.Replace("ð", "g");
            #endregion
            #region Boþluklar Tireye Dönüþtürülüyor
            text = text.Replace(" ", "-");
            #endregion
            #region Sorunlu Karakterler Kaldýrýlýyor
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
    }
}
