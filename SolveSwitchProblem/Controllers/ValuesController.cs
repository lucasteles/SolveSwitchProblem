using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SolveSwitchProblem.Commands;
using SolveSwitchProblem.Enums;

namespace SolveSwitchProblem.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IEnumerable<ICommand> Commands;

        public ValuesController(IEnumerable<ICommand> commands)
        {
            Commands = commands;
        }

        public string Get() => "OK!";

        [HttpGet("{type}")]
        public string Get(int type)=>
             Commands
                .FirstOrDefault(c => c.Type == (CommandTypes)type)
                ?.Execute()
                ?? string.Empty;
        
              
        

       
    }
}
