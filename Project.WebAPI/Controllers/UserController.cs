using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Schema;
using Project.Core;

namespace User.WebAPI.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    [Produces("application/json")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = UserManager.Instance.GetAllUsers();
            return Ok(result);
        }

        // GET: api/User/5
        [HttpGet("{userID}", Name = "GetUserByID")]
        public IActionResult GetUserByID(string userID)
        {
            Guid.TryParse(userID, out Guid ID);
            return Ok(UserManager.Instance.GetUserByID(ID));
        }

        // POST: api/User
        [HttpPost]
        public IActionResult CreateUser()
        {
            UserManager.Instance.CreateUser();
            return Ok("");
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
