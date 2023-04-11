using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.Controllers.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MinhaPrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            List<UserModel> usersModels = new List<UserModel>();

            usersModels.Add(new UserModel() { Id = 1, Name = "Fellipi Borges", Email = "fellipiborgesmc@gmail.com"});

            return usersModels;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public UserModel Get(int id)
        {
            UserModel user = new UserModel() { Id = 1, Name = "Fellipi Borges", Email = "fellipiborgesmc@gmail.com" };

            return user;
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] UserModel user)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UserModel user)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
