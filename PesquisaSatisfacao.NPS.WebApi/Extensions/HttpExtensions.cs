using System.Net;
using System.Net.Http;

namespace PesquisaSatisfacao.NPS.WebApi.Extensions
{
    public static class HttpExtensions
    {
        public static bool IsSuccess(this HttpStatusCode statusCode) =>
            new HttpResponseMessage(statusCode).IsSuccessStatusCode;
    }
}
