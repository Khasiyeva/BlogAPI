﻿using BlogApp.Business.DTOs.BrandDtos;
using BlogApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Services.Interfaces
{
    public interface IBrandService
    {
        Task<ICollection<Brand>> GetAllAsync();
        Task<Brand> GetByIdAsync(int id);
        Task<Brand> Create(CreateBrandDto brand);
    }
}
