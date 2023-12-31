﻿using Core.Entities;
using System.Text.Json.Serialization;

namespace Entities.Concretes
{
    public class User : Entity<Guid>
    {
        public Guid AppealId { get; set; } 
        public string? NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? BirthDate { get; set; }

        public string? Country { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? AddressDetails { get; set; }
        public string? AboutMe { get; set; }
        public string? Phone { get; set; }

        public ICollection<SocialMediaAccount> MyProperty { get; set; }
        public ICollection<UserSurvey> UserSurveys { get; set; }
        public ICollection<UserCourse> UserCourses { get; set; }
        public ICollection<UserAnnouncement> UserAnnouncements { get; set; }
        public Appeal Appeal { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
    }
}
