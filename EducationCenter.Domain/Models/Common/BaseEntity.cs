﻿using System;

namespace EducationCenter.Domain.Models.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; } 
            = DateTime.Now;

        public DateTime UpdatedDate { get; set; }
    }
}
