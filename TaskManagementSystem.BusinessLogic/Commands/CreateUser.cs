using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.BusinessLogic.Interfaces;
using TaskManagementSystem.BusinessLogic.Utilities;

namespace TaskManagementSystem.BusinessLogic.Commands
{
    public static class CreateUser
    {
        public class Request : IRequest<Result>
        {

        }

        public class Result : IActionResult
        {
            public HttpStatusCode Status { get; set; }
            public Guid UserId { get; set; }
            public string ErrorMessage { get; set; } = string.Empty;

            public Result(HttpStatusCode status)
            {
                Status = status; 
            }

            public Result(string errorMessage)
            {
                Status= HttpStatusCode.BadRequest;
                ErrorMessage = errorMessage;
            }

            public Result (Guid serId)
            {
                UserId = UserId;
            }
        }
    }
}
