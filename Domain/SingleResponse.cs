using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TalebiAPI.Domain
{
    internal class SingleResponse<T>
    {
        internal SingleResponse()
        {

        }

        public SingleResponse(T data, HttpStatusCode httpStatusCode)
        {
            Data = data;
            StatusCode = httpStatusCode;
        }

        public SingleResponse(string errorMessage, HttpStatusCode httpStatusCode)
        {
            HasError = true;
            ErrorMessage = errorMessage;
            StatusCode = httpStatusCode;
        }

        public bool HasError { get; set; }
        public string ErrorMessage { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }


    //public static class ApiExtensionMethods
    //{
    //    public static ActionResult ToHttpResponse<TModel>(this SingleResponse<TModel> response)
    //    {
    //        var objectResult = new ObjectResult(response)
    //        {
    //            StatusCode = ((int)response.StatusCode > 0) ? (int)response.StatusCode : StatusCodes.Status200OK
    //        };
    //        return objectResult;
    //    }
    //}
}