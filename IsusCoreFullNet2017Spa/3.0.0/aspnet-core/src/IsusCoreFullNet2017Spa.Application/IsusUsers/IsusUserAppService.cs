﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using IsusCoreFullNet2017Spa.IsusUsers.Dto;
using IsusCoreFullNet2017Spa.Authorization.IsusUsers;
using Abp.Domain.Repositories;
using IsusCoreFullNet2017Spa.IsusModels;

namespace IsusCoreFullNet2017Spa.IsusUsers
{
    public class IsusUserAppService : IsusCoreFullNet2017SpaAppServiceBase, IIsusUserAppService
    {
        private readonly IsusUserManager _isusUserManager;
        private readonly IRepository<IsusUser, long> _isusUserRepository;

        public const string DefaultPassword = "Qwe!23Asd";

        public IsusUserAppService(IsusUserManager isusUserManager, IRepository<IsusUser, long> isusUserRepository)
        {
            _isusUserManager = isusUserManager;
            _isusUserRepository = isusUserRepository;
        }

        public async Task<PagedResultDto<IsusUserDto>> GetAll(PagedResultRequestDto input, string filter)
        {
            var query = _isusUserRepository.GetAll().Where(iu => iu.SystemUser == null);
            if (!string.IsNullOrEmpty(filter))
            {
                filter = filter.ToUpper();
                query = query.Where(iu => iu.CurrentName.ToUpper().StartsWith(filter));
            }

            return new PagedResultDto<IsusUserDto>
            {
                TotalCount = query.Count(),
                Items = ObjectMapper.Map<List<IsusUserDto>>(await query.Skip(input.SkipCount).Take(input.MaxResultCount)
                    .ToAsyncEnumerable().ToList()),
            };
        }

        public async Task<bool> MoveToMainUserTable(long isusUserId)
        {
            var isusUser = await _isusUserRepository.GetAsync(isusUserId);
            if (string.IsNullOrEmpty(isusUser.AccountPwd))
            {
                _isusUserManager.SetPassword(isusUser, DefaultPassword);
                await _isusUserRepository.UpdateAsync(isusUser);
            }

            var user = await _isusUserManager.CreateUserForIsusUserAsync(isusUser, isusUser.AccountPwd);
            return true;
        }
    }
}