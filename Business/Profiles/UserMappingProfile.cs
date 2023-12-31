﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Dtos.User.Requests;
using Business.Dtos.User.Responses;
using Business.Dtos.UserCourse.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, CreateUserRequest>().ReverseMap();
            CreateMap<User, DeleteUserRequest>().ReverseMap();
            CreateMap<User, UpdateUserRequest>().ReverseMap();
            //CreateMap<User, GetByIdUserRequest>().ReverseMap();
            CreateMap<User, CreatedUserResponse>().ReverseMap();
            CreateMap<User, UpdatedUserResponse>().ReverseMap();
            CreateMap<User, DeletedUserResponse>().ReverseMap();
            CreateMap<User, GetUserResponse>().ReverseMap();


            CreateMap<User, GetListUserResponse>() .ReverseMap();
            

            CreateMap<User, GetListUserResponse>().ReverseMap();

            CreateMap<User, GetByIdUserResponse>().ReverseMap();
            CreateMap<User, GetByIdUserResponse>()
                .ForMember(destinationMember: b => b.Courses, memberOptions: opt => opt.MapFrom(b => b.UserCourses))
                .ForMember(destinationMember: p => p.Name, memberOptions: opt => opt.MapFrom(p => p.FirstName))
                .ForMember(destinationMember: c => c.Id, memberOptions: opt => opt.MapFrom(c => c.Id))
                .ReverseMap();

            CreateMap<Paginate<User>, Paginate<GetListUserResponse>>().ReverseMap();
        }
    }
}
