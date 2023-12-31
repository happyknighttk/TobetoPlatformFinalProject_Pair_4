﻿using Business.Abstracts;
using Business.Dtos.Instructor.Requests;
using Business.Dtos.UserCourse.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCourseController : ControllerBase
    {
        IUserCourseService _userCourseService;
        public UserCourseController(IUserCourseService userCourseService)
        {
            _userCourseService = userCourseService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateUserCourseRequest createUserCourseRequest)
        {
            var result = await _userCourseService.AddAsync(createUserCourseRequest);
            return Ok(result);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList()
        {
            var result = await _userCourseService.GetListAsync();
            return Ok(result);
        }
    }
}
