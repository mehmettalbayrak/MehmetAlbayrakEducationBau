using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BooksApp.Shared.ResponseDTOs
{
    //Factory Design Pattern
    public class Response<T>
    {
        public T Data { get; set; }
        public List<string> Errors { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        [JsonIgnore]
        public bool IsSucceeded { get; set; }

        #region Success Liste Summary
        /// <summary>
        /// Bu metot, işlemin başarılı olduğu durumlarda, başarılı bir cevapla birlikte veriyi ve durum kodunu döndürmek için kullanılır.
        /// </summary>
        /// <param name="data">Geri döndürülecek veri.</param>
        /// <param name="statusCode">Geri döndürülecek durum kodu. Örnek: 201, 401 gibi..</param>
        /// <returns>Response<typepramref name="T"/></returns>
        #endregion
        public static Response<T> Success(T data, int statusCode)
        {
            return new Response<T>
            {
                Data = data,
                StatusCode = statusCode,
                IsSucceeded = true
            };
        }

        #region Success Durum Kodu Summary
        /// <summary>
        /// Bu metot, geriye başarılı bir cevap olarak sadece durum kodu döndürmek için kullanılır.
        /// </summary>
        /// <param name="statusCode">Geri döndürülecek durum kodu.</param>
        /// <returns>Response<typeparamref name="T"></returns>
        #endregion
        public static Response<T> Success(int statusCode)
        {
            return new Response<T>
            {
                Data = default(T),
                StatusCode = statusCode,
                IsSucceeded = true
            };
        }

        #region Fail Summary
        /// <summary>
        /// Bu metot, geriye başarısız bir cevap olarak hata listesini ve durum kodunu döndürmek için kullanılır.
        /// </summary>
        /// <param name="errors">Geri döndürülecek hata listesi.</param>
        /// <param name="statusCode">Döndürülecek hata kodu. Örn: 401, 503</param>
        /// <returns>Response<typepramref name="T"></returns>
        #endregion
        public static Response<T> Fail(List<string> errors, int statusCode)
        {
            return new Response<T>
            {
                Errors = errors,
                StatusCode = statusCode,
                IsSucceeded = false
            };
        }

        #region Fail Summary
        /// <summary>
        /// Bu metot, geriye başarısız bir cevap olarak bir hata ve durum kodunu döndürmek için kullanılır.
        /// </summary>
        /// <param name="error">Geri döndürülecek hata.</param>
        /// <param name="statusCode">Döndürülecek hata kodu. Örn: 401, 503</param>
        /// <returns>Response<typepramref name="T"></returns>
        #endregion
        public static Response<T> Fail(List<string> error, int statusCode)
        {
            return new Response<T>
            {
                Errors = new List<string>(error),
                StatusCode = statusCode,
                IsSucceeded = false
            };
        }
    }
}
