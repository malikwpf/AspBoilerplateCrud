using System.Threading.Tasks;
using Crud.Models.TokenAuth;
using Crud.Web.Controllers;
using Shouldly;
using Xunit;

namespace Crud.Web.Tests.Controllers
{
    public class HomeController_Tests: CrudWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}