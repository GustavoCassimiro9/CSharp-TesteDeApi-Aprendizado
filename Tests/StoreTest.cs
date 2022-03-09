using AutomacaoPetStore.Services;
using Xunit;
using Xunit.Abstractions;


namespace AutomacaoPetStore.Tests
{
    public class StoreTest
    {
        private readonly ITestOutputHelper output;

        public StoreTest(ITestOutputHelper output)
        {
            this.output = output;
        }
      
     


        //Get Store Inventory
        //Estrutura Basica do metodo de test Xunit 
        [Fact(DisplayName ="Get All Story Inventory")] // Metodo de teste
        [Trait("category","Store")] // Categoria para o metodo 
        public void Get_StoreInventory()
        {
            new StoreServiceWorkFlow(output).Validate_GetAllStreInventory();
        }

        //Get Store Order By Id 
        [Fact(DisplayName = "Get By Order")]
        [Trait("category","Store")]

        public void Get_StoreOrderByOrderId()
        {
          new StoreServiceWorkFlow(output).Validate_GetStoreOrderById(int.Parse(CustomConfigurationProvider.GetSection("orderId")));
        }
    }
}
