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
            #region A��klamalar
            /*
             * Bu metot kendisine g�nderilen url bilgisinin i�indeki;
             * 1) Latin alfabesine �evrilirken sorun yaratma ihtimali bulunan �, � gibi harfleri d�n��t�recek.
             * Di�er T�rk�e karakterlerin yerine latin alfabesindeki kar��l�k gelen k���k harflerini koyacak �->o, �->s gibi
             * Bo�luklar�n yerine - i�areti koyaacak
             * Nokta(.), slash(/), noktal� virg�l(;) gibi karakterleri de yok edecek.
             */
            #endregion
            #region Sorunlu T�rk�e Karakterler K���k Harfe D�n��t�r�l�yor
            text = text.Replace("I", "i");
            text = text.Replace("�", "i");
            text = text.Replace("�", "i");
            #endregion
            #region Di�erleri K���k Harfe D�n���t�r�l�yor
            text = text.ToLower();
            #endregion
            #region T�rk�e Karakterler Latin Karakterlerine D�n��t�r�l�yor
            text = text.Replace("�", "o");
            text = text.Replace("�", "u");
            text = text.Replace("�", "s");
            text = text.Replace("�", "c");
            text = text.Replace("�", "g");
            #endregion
            #region Bo�luklar Tireye D�n��t�r�l�yor
            text = text.Replace(" ", "-");
            #endregion
            #region Sorunlu Karakterler Kald�r�l�yor
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
            text = text.Replace("�", "");
            text = text.Replace("+", "");
            #endregion
            return text;
        }
    }
}
