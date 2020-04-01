using System.Net;  
using System.Net.Http;  
using System.Web.Http.Filters;  

namespace Task_Management_System.Filters
{
    public class CustomExceptionFilter : ExceptionFilterAttribute, IExceptionFilter
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {

            if (actionExecutedContext.Exception is ExceptionRepo)
            {
                var res = actionExecutedContext.Exception.Message;

                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(res),
                    ReasonPhrase = res
                };

                actionExecutedContext.Response = response;
            }
            /*HttpStatusCode status = HttpStatusCode.InternalServerError;
            string message = string.Empty;
            var exceptionType = actionExecutedContext.Exception.GetType();
            if(exceptionType == null)
            {
                message = "Not found.";
                status = HttpStatusCode.NotFound;
            }
            actionExecutedContext.Response = new HttpResponseMessage()
            {
                Content = new StringContent(message, System.Text.Encoding.UTF8, "text/plain"),
                StatusCode = status
            };
            base.OnException(actionExecutedContext);
            */
        }
    }
}
