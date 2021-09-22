using FBJ.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBJ.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SequenceController : ControllerBase
    {
        
        private readonly ILogger<SequenceController> _logger;
        private readonly ISequenceProvider _sequenceProvider;

        public SequenceController(ILogger<SequenceController> logger, ISequenceProvider sequenceProvider)
        {
            _logger = logger;
            _sequenceProvider = sequenceProvider;
        }

        [HttpGet("{number}")]
        public IActionResult GetSequence(int number)
        {
            return Ok(_sequenceProvider.GenerateSequence(number));
        }
    }
}
