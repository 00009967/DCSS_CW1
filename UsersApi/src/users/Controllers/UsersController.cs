using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsersApi.src.Data;
using UsersApi.src.Global.Interfaces;
using UsersApi.src.users.DTO;
using UsersApi.src.users.Models;

namespace UsersApi.src.users.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public UsersController(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET: api/Users
        [HttpGet]
        public IActionResult GetUser()
        {
            try
            {
                var users = _repository.User.GetAllUsers();
                var userResult = _mapper.Map<IEnumerable<UserDto>>(users);
                return Ok(userResult);
            } catch (Exception e)
            {
                return StatusCode(500, $"Internal server error -> \n {e} ");
            }
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            try
            {
                var user = _repository.User.GetUserById(id);

                if (user == null)
                {
                    return NotFound();
                }
                var userResult = _mapper.Map<UserDto>(user);
                return Ok(userResult);
            } catch (Exception e)
            {
                return StatusCode(500, $"Internal Server Error ! \n {e}");
            }
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, [FromBody]UpdateUserDto user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest("User object is null");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("User object is Invalid");
                }
                
                var userEntity = _repository.User.GetUserById(id);
                if(userEntity == null)
                {
                    return NotFound();
                }

                _mapper.Map(user, userEntity);

                _repository.User.UpdateUser(userEntity);
                _repository.Save();

                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal Server Error ! \n {e}");
            }
        }

        // POST: api/Users
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public IActionResult PostUser([FromBody] CreateUserDto user)
        {
            try
            {
                if(user == null)
                {
                    return BadRequest("User object is null");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("User object is Invalid");
                }

                var userEntity = _mapper.Map<User>(user);
                _repository.User.CreateUser(userEntity);
                _repository.Save();

                var createdUser = _mapper.Map<UserDto>(userEntity);

                return CreatedAtAction(nameof(GetUserById), new { id = createdUser.Id }, createdUser);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal Server Error ! \n {e}");
            }
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                var userEntity = _repository.User.GetUserById(id);
                if (userEntity == null)
                {
                    return NotFound();
                }
                _repository.User.DeleteUser(userEntity);
                _repository.Save();

                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal Server Error ! \n {e}");
            }
        }
    }
}
