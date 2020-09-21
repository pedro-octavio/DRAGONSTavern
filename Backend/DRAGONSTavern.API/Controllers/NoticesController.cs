using System;
using DRAGONSTavern.Domain.Core.Interfaces.Services;
using DRAGONSTavern.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DRAGONSTavern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticesController : ControllerBase
    {
        private readonly INoticeService _noticeService;

        public NoticesController(INoticeService noticeService) => _noticeService = noticeService;

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_noticeService.GetAll());
            }
            catch (Exception ex)
            {

                return BadRequest(error: ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] string id)
        {
            try
            {
                return Ok(_noticeService.GetById(id));
            }
            catch (Exception ex)
            {

                return BadRequest(error: ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Notice notice)
        {
            try
            {
                notice.GenerateId();

                _noticeService.Add(notice);

                return Ok(notice.Id);
            }
            catch (Exception ex)
            {

                return BadRequest(error: ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Notice notice)
        {
            try
            {
                _noticeService.Update(notice);

                return Ok("Notice updated successfully.");
            }
            catch (Exception ex)
            {

                return BadRequest(error: ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] string id)
        {
            try
            {
                _noticeService.Remove(id);

                return Ok("Notice removed successfully.");
            }
            catch (Exception ex)
            {

                return BadRequest(error: ex.Message);
            }
        }
    }
}
