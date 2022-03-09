using Xunit.Abstractions;
using AutomacaoPetStore.Helpers;
using Xunit;

namespace AutomacaoPetStore.Services
{
    public class UserServiceWorkFlow
    {
        private readonly ITestOutputHelper LoggerOutput;

        public UserServiceWorkFlow(ITestOutputHelper LoggerOutput)
        {
            this.LoggerOutput = LoggerOutput;

        }
        public void Get_ValidateNameUser(string username)
        {
            var response = new UserAPIActions(LoggerOutput).Get_UserName(username);

            if (response != null)
            {
                Assert.Equal(username, response.username);
            }
            else
            {
                LoggerOutput.WriteLine("Get Falhou!!!");
                Assert.NotNull(response);
            }
        }
    }
}
