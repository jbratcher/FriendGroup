using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FriendGroup.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FriendGroupInstanceController : ControllerBase
    {
        private readonly ILogger<FriendGroupInstanceController> _logger;

        public FriendGroupInstanceController(ILogger<FriendGroupInstanceController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<FriendGroupInstance> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new FriendGroupInstance
            {
                GroupId = rng.Next(1, 10),
                GroupName = "Group " + rng.Next(1, 10),
                GroupMembers = new string[4] { "Jim", "Pam", "Michael", "Dwigt"}
            }
            )
            .ToArray();
        }
    }
}
