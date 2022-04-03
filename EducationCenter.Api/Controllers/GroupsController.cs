﻿using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Group;
using EducationCenter.Service.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EducationCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : GenericController<Group, GroupCreationalDTO>
    {
        public GroupsController(IGenericService<Group, GroupCreationalDTO> service) : base(service)
        {
        }
    }
}