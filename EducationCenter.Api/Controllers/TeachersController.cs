﻿using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Teacher;
using EducationCenter.Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : GenericController<Teacher, TeacherInputDTO>
    {
        public TeachersController(IGenericService<Teacher, TeacherInputDTO> service) : base(service)
        {
        }
    }
}
