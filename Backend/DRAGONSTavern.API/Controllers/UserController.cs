using System;
using DRAGONSTavern.Domain.Core.Interfaces.Services;
using DRAGONSTavern.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DRAGONSTavern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ITokenService _tokenService;

        public UserController(IUserService userService, ITokenService tokenService)
        {
            _userService = userService;
            _tokenService = tokenService;
        }

        [HttpGet("{email}")]
        [Authorize]
        public IActionResult Get([FromRoute] string email)
        {
            try
            {
                return Ok(_userService.GetByEmail(email));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Post([FromBody] User user)
        {
            try
            {
                user.GenerateId();

                _userService.Add(user);

                return Ok(user);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Authorize]
        public IActionResult Put([FromBody] User user)
        {
            try
            {
                _userService.Update(user);

                return Ok("User updated successfully.");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete([FromRoute] string id)
        {
            try
            {
                _userService.Remove(id);

                return Ok("User removed successfully.");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("Authenticate")]
        [AllowAnonymous]
        public IActionResult Authenticate([FromBody] User user)
        {
            try
            {
                return Ok(_tokenService.GenerateToken(user));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
