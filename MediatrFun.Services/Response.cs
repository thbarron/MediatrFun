using System.Collections.Generic;
using MediatrFun.Data.Models;

namespace MediatrFun.Services
{
    public static class Response
    {
        public static Response<T> Fail<T>(string message, T data) => 
            new Response<T>(data, message, true);
        public static Response<T> Ok<T>(T data, string message) => 
            new Response<T>(data, message, false);
    }

    public class Response<T>
    {
        public Response(T data, string message, bool error)
        {
            Data = data;
            Message = message;
            Error = error;
        }
        
        public T Data { get; set; }
        public string Message { get; set; }
        public bool Error { get; set; }
    }
}