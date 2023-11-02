using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.BusinessLogic.Interfaces;

namespace TaskManagementSystem.BusinessLogic.Utilities
{
    public class BasicActionResult : IActionResult
    {
        public HttpStatusCode Status { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;

        public BasicActionResult(string errorMessage) 
        {
            ErrorMessage = errorMessage;
            Status= HttpStatusCode.BadRequest;
        }

        public BasicActionResult()
        {
            Status= HttpStatusCode.OK;
        }

        public BasicActionResult(HttpStatusCode statusCode)
        {
            Status = statusCode;
        }
    }
}
