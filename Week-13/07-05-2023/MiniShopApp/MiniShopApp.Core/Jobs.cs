namespace MiniShopApp.Core
{
    public static class Jobs //Static olduğu için new demeden bir nesne oluşturabileceğiz.
    {
        public static string GetUrl(string text)
        {
            #region Açıklamalar
            /*
             Bu metod kendisine gönderilen url bilgisinin içindeki;
            1- Latin alfabesine çevrilirken sorun yaratma ihtimali bulunan ı, İ gibi harfleri dönüştürecek.
            2- Diğer Türkçe karakterlerin yerine latin alfabesindeki karşılık gelen küçük harfleri koyacak. Ö'yü O'ya çevirecek gibi.
            3-Boşlukların yerine - işareti koyacak.
            4-Nokta slash noktalı virgül gibi karakterleri de yok edecek. 
             */
            #endregion

            #region Sorunlu Türkçe Karakterler Küçük Harfe Düzeltiliyor
            text = text.Replace("I", "i");
            text = text.Replace("İ", "i");
            text = text.Replace("ı", "i");
            #endregion

            #region Küçük Harfe Dönüştürülüyor
            text = text.ToLower();
            #endregion

            #region Türkçe Karakterler Latin Dönüştürülüyor
            text = text.Replace("ö", "o");
            text = text.Replace("ü", "u");
            text = text.Replace("ş", "s");
            text = text.Replace("ç", "c");
            text = text.Replace("ğ", "g");
            #endregion

            #region Boşlukları Tireye Dönüştürme
            text.Replace(" ", "-");
            #endregion

            #region Sorunlu Karakterler Kaldırılıyor
            text = text.Replace(".", "");
            text = text.Replace(",", "");
            text = text.Replace(":", "");
            text = text.Replace(";", "");
            text = text.Replace("?", "");
            text = text.Replace("!", "");
            text = text.Replace("/", "");
            text = text.Replace("\\", "");
            text = text.Replace("'", "");
            text = text.Replace("^", "");
            text = text.Replace("*", "");
            text = text.Replace("=", "");
            text = text.Replace("(", "");
            text = text.Replace(")", "");
            text = text.Replace("[", "");
            text = text.Replace("]", "");
            text = text.Replace("_", "-");
            text = text.Replace("&", "");
            text = text.Replace("~", "");
            text = text.Replace("@", "");
            text = text.Replace("`", "");
            text = text.Replace("|", "");
            text = text.Replace("<", "");
            text = text.Replace(">", "");
            text = text.Replace("€", "");
            text = text.Replace("$", "");
            text = text.Replace("{", "");
            text = text.Replace("}", "");
            text = text.Replace("+", "");

            #endregion

            return text;
        }
    }
}