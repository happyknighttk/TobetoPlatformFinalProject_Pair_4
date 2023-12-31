﻿using Business.Dtos.User.Responses;
using Entities.Concretes;

namespace Business.Dtos.Course.Responses
{
    public class GetListCalendarEventResponse
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public string InstructorName { get; set; }
        public DateTime EventDate { get; set; } // Etkinlik tarihi
        public string EventDetails { get; set; } // Etkinlik detayları
    }
}