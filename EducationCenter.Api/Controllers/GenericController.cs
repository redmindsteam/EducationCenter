﻿using EducationCenter.Domain.Common;
using EducationCenter.Domain.Configurations;
using EducationCenter.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducationCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<TModel, TDTO> 
        : ControllerBase where TModel : BaseEntity
    {
        private readonly IGenericService<TModel, TDTO> _service;

        public GenericController(IGenericService<TModel, TDTO> service)
        {
            this._service = service;
        }

        [HttpGet]
        public async Task<BaseResponse<IEnumerable<TModel>>> Get(
            [FromQuery] PaginationParams @params)
        {
            return await _service.GetAllAsync(@params);
        }

        [HttpGet("{id}")]
        public async Task<BaseResponse<TModel>> Get(int id)
        {
            return await _service.GetAsync(x => x.Id.Equals(id));
        }

        [HttpPost]
        public async Task<BaseResponse<TModel>> Post(
            [FromBody] TDTO EmployeeDto)
        {
            return await _service.CreateAsync(EmployeeDto);
        }

        [HttpPut("{id}")]
        public async Task<BaseResponse<TModel>> Put(int id,
            [FromBody] TDTO employeeDto)
        {
            return await _service.UpdateAsync(id, employeeDto);
        }

        [HttpDelete("{id}")]
        public async Task<BaseResponse<bool>> Delete(int id)
        {
            return await _service.DeleteAsync(x => x.Id.Equals(id));
        }
    }
}
