using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using IsusCoreFullNet2017Spa.IsusUsers.Dto;
using IsusCoreFullNet2017Spa.Authorization.IsusUsers;
using Abp.Domain.Repositories;
using IsusCoreFullNet2017Spa.IsusModels;
using Abp.Authorization;
using IsusCoreFullNet2017Spa.Authorization;

namespace IsusCoreFullNet2017Spa.IsusUsers
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
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
            var query = _isusUserRepository.GetAll().Where(iu => iu.SystemUser == null || iu.SystemUser.IsDeleted);
            if (!string.IsNullOrEmpty(filter))
            {
                filter = filter.ToUpper();
                query = query.Where(iu => iu.CurrentName.ToUpper().StartsWith(filter));
            }

            query = query.OrderBy(iu => iu.CurrentName);

            var items = ObjectMapper.Map<List<IsusUserDto>>(await query.Skip(input.SkipCount).Take(input.MaxResultCount)
                    .ToAsyncEnumerable().ToList());

            items.ForEach(iu =>
            {
                if (!string.IsNullOrEmpty(iu.AccountPwd))
                {
                    iu.AccountPwd = "111111";
                    iu.AccountPwdMd5 = null;
                }
            });

            return new PagedResultDto<IsusUserDto>
            {
                TotalCount = query.Count(),
                Items = items,
            };
        }

        public async Task<bool> MoveToMainUserTable(long isusUserId, string login, string password)
        {
            var isusUser = await _isusUserRepository.GetAsync(isusUserId);
            bool needsUpdate = false;
            if(string.IsNullOrEmpty(isusUser.AccountPwd))
            {
                isusUser.AccountName = login;
                needsUpdate = true;
            }

            if (string.IsNullOrEmpty(isusUser.AccountPwd))
            {
                _isusUserManager.SetPassword(isusUser, password ?? DefaultPassword);
                needsUpdate = true;
            }

            if (needsUpdate)
            {
                await _isusUserRepository.UpdateAsync(isusUser);
            }

            var user = await _isusUserManager.CreateUserForIsusUserAsync(isusUser, isusUser.AccountPwd);
            return true;
        }

        public Task<IsusUserDto> Get(long id)
        {
            throw new NotImplementedException();
        }
    }
}
