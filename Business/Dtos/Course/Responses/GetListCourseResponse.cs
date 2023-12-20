﻿using Business.Dtos.User.Responses;

namespace Business.Dtos.Course.Responses
{
    public class GetListCourseResponse
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public string InstructorName { get; set; }
        public string Name { get; set; }
    }
}