﻿using BlogApp.Business.DTOs.BrandDtos;
using BlogApp.Business.Services.Interfaces;
using BlogApp.Core.Entities;
using BlogApp.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Services.Implementations
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _repo;

        public BrandService(IBrandRepository repo)
        {
            _repo = repo;
        }

        public async Task<Brand> Create(CreateBrandDto brand)
        {
            if (brand == null) throw new Exception("Not null");
            Brand brands = new Brand()
            {
                Name = brand.Name,
            };
            await _repo.Create(brands);
            await _repo.SaveChangesAsync();
            return brands;


        }

        public async Task<ICollection<Brand>> GetAllAsync()
        {
            var brands=await _repo.GetAllAsync();

            return await brands.ToListAsync();
        }

        public Task<Brand> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
