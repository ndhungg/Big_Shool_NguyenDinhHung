using BigSchool_NguyenDinhHung.DTOs;
using BigSchool_NguyenDinhHung.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BigSchool_NguyenDinhHung.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendance.Any(a => a.AtttendeeId == userId && a.CourseId == attendanceDto.CourseId))
                return BadRequest("The Attendance already exitsts!");
            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AtttendeeId = userId
            };
            _dbContext.Attendance.Add(attendance);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
