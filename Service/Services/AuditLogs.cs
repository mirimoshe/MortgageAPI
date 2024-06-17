﻿using AutoMapper;
using Common.Entities;
using Repositories.Interface;
using Repositories.Repositories;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AuditLogs : IService<AuditLogsDto>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<AuditLogsDto> _repository;

        public AuditLogs (IRepository<AuditLogsDto> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<AuditLogsDto> AddAsync(AuditLogsDto entity)
        {
            return _mapper.Map<AuditLogsDto>(await _repository.AddItemAsync(_mapper.Map <AuditLogsDto>(entity)));
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<List<AuditLogsDto>> GetAllAsync()
        {
            return _mapper.Map<List<AuditLogsDto>>(await _repository.GetAllAsync());
        }

        public async Task<AuditLogsDto> GetAsync(int id)
        {
            return _mapper.Map<AuditLogsDto>(await _repository.GetAsync(id));
        }

        public async Task Post(AuditLogsDto item)
        {
           await _repository.Post(_mapper.Map<AuditLogsDto>(item));
        }

        public async Task UpdateAsync(int id, AuditLogsDto entity)
        {
            await _repository.UpdateAsync(id, _mapper.Map<AuditLogsDto>(entity));
        }
    }
}
