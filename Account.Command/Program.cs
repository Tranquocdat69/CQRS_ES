using Account.Command.Commands;
using Account.Command.Infrastructure;
using CQRS.Commands;
using CQRS.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Account.Command
{
    public class Program
    {
       /* private static CommandDispatcher _commandDispatcher;
        private static CommandHandler _commandHandler;*/
        
        public static void Main(string[] args)
        {
            /*_commandDispatcher = new AccountCommandDispatcher();
            _commandHandler = new AccountCommandHandler();

            OpenAccountCommand openAccountCommand = new OpenAccountCommand();

            _commandDispatcher.RegisterHandler<OpenAccountCommand>(openAccountCommand, _commandHandler.handle);*/

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
