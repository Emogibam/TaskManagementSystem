using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.BusinessLogic.Utilities;

namespace TaskManagementSystem.BusinessLogic.Commands
{
    public static class CreateUser
    {
        public class Query : IRequest<Result>
        {

        }

        public class Result : BasicActionResult
        {

        }
    }
}
