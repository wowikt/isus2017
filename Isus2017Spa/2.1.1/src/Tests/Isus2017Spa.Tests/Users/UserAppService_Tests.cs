using System.Data.Entity;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Isus2017Spa.Users;
using Isus2017Spa.Users.Dto;
using Shouldly;
using Xunit;

namespace Isus2017Spa.Tests.Users
{
    public class UserAppService_Tests : Isus2017SpaTestBase
    {
        private readonly IUserAppService _userAppService;

        public UserAppService_Tests()
        {
            _userAppService = Resolve<IUserAppService>();
        }

        [Fact]
        public async Task GetUsers_Test()
        {
            //Act
            var output = await _userAppService.GetAll(new PagedResultRequestDto { MaxResultCount = 20, SkipCount = 0 });

            //Assert
            output.Items.Count.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task CreateUser_Test()
        {
            //Act
            await _userAppService.Create(
                new CreateUserDto
                {
                    EmailAddress = "john@volosoft.com",
                    IsActive = true,
                    Name = "John",
                    Surname = "Nash",
                    Password = "123qwe",
                    UserName = "john.nash"
                });

            await UsingDbContextAsync(async context =>
            {
                var johnNashUser = await context.Users.FirstOrDefaultAsync(u => u.UserName == "john.nash");
                johnNashUser.ShouldNotBeNull();
            });
        }
    }
}
