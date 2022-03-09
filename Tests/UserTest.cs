using AutomacaoPetStore.Services;
using Xunit;
using Xunit.Abstractions;

namespace AutomacaoPetStore.Tests
{
    public class UserTest
    {
        private readonly ITestOutputHelper output;

        public UserTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact(DisplayName ="Get Name user")]
        [Trait("category","User")]
        public void Get_UserName()
        {
            new UserServiceWorkFlow(output).Get_ValidateNameUser(CustomConfigurationProvider.GetSection("username"));
        }
    }
}
