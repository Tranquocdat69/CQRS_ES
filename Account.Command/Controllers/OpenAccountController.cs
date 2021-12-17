using Account.Command.Commands;
using CQRS.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.Command.Controllers
{
    [Route("api/v1/openBankAccount")]
    [ApiController]
    public class OpenAccountController : ControllerBase
    {
        /*private CommandDispatcher _commandDispatcher;
        public OpenAccountController(CommandDispatcher commandDispatcher)
        {
            this._commandDispatcher = commandDispatcher;
        }*/
        private IMediator _mediator;

        public OpenAccountController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost]
        public string OpenAccount([FromBody] OpenAccountCommand command)
        {
            var id = Guid.NewGuid().ToString();
            command.setId(id);

            try
            {
                _mediator.Send(command);
                //_commandDispatcher.Send(command);
                return "tao thanh cong";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
           
        } 
    }
}
