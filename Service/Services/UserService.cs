﻿using AutoMapper;
using Common.Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class UserService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<UsersDto> _repository;

        public UserService(IRepository<UsersDto> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<UsersDto> AddAsync(UsersDto entity)
        {
            return _mapper.Map<UsersDto>(await _repository.AddItemAsync(_mapper.Map<UsersDto>(entity)));
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<List<UsersDto>> GetAllAsync()
        {
            return _mapper.Map<List<UsersDto>>(await _repository.GetAllAsync());
        }

        public async Task<UsersDto> GetAsync(int id)
        {
            return _mapper.Map<UsersDto>(await _repository.GetAsync(id));
        }

        public async Task Post(UsersDto item)
        {
            await _repository.Post(_mapper.Map<UsersDto>(item));
        }

        public async Task UpdateAsync(int id, UsersDto entity)
        {
            await _repository.UpdateAsync(id, _mapper.Map<UsersDto>(entity));
        }
    }
}
