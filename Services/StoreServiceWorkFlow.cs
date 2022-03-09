using Xunit.Abstractions;
using AutomacaoPetStore.Helpers;
using Xunit;

namespace AutomacaoPetStore.Services
{
    public class StoreServiceWorkFlow
    {
        private readonly ITestOutputHelper LoggerOutput;

        public StoreServiceWorkFlow(ITestOutputHelper LoggerOutput)
        {
            this.LoggerOutput = LoggerOutput;

        }
        public void Validate_GetStoreOrderById(int orderId) //Metodos para os Asserts
        {

            var response = new StoreAPIActions(LoggerOutput).Get_StoreOrderByOrderId(orderId);

            if (response != null)
            {
                Assert.Equal(orderId, response.id);
            }
            else
            {
                LoggerOutput.WriteLine("Get Falhou!!!");
                Assert.NotNull(response);
            }


        }

        public void Validate_GetAllStreInventory() //Metodos para os Asserts
        {
            var response = new StoreAPIActions(LoggerOutput).Get_AllStoreInventory();

            if(response != null)
            {
                Assert.Equal(int.MinValue.GetType(), response.num1.GetType());
            }
            else
            {
                LoggerOutput.WriteLine("Get Falhou!!!");
                Assert.NotNull(response);
            }
            
    
        }
        
    }
}
