﻿using EducationCenter.Data.DbContexts;
using EducationCenter.Data.IRepasitories;
using EducationCenter.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCenter.Data.Repasitories
{
    public class StudentRepasitory : GenericRepository<Student>, IStudentRepasitory
    {
        public StudentRepasitory(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Student>> GetStudentGroupsAsync(int id)
        {
            var studentGroups = await dbContext.Students.Where(s => s.Id == id)
                .Include(student => student.Groups).ToListAsync();

            return studentGroups;
        }
    }
}