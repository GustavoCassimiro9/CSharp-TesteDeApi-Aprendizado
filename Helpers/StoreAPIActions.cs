using System;
using Xunit.Abstractions;
using RestSharp;
using System.Text.Json;
using AutomacaoPetStore.Models;
namespace AutomacaoPetStore.Helpers
{
    public class StoreAPIActions
    {
        private  ITestOutputHelper LoggerOutput;

        public ITestOutputHelper Logger
        {
            get { return LoggerOutput; }
            set { LoggerOutput = value; }
        }

        public StoreAPIActions(ITestOutputHelper LoggerOutput)
        {
            this.LoggerOutput = LoggerOutput;
        }
        // Get Store Order By Order Id
        public Get_StoreOrder_Response Get_StoreOrderByOrderId(int orderId)//End Point com parametro
        {
            // Criando o ResCliente
            RestClient restClient = new RestClient(); //Criar um cliente
            RestRequest restRequest = new RestRequest(Method.GET); // Criar uma requisição 
            IRestResponse restResponse;

            restClient.BaseUrl = new Uri(APIMethods.StoreOrder + orderId);
            restResponse = restClient.Execute(restRequest);
            
            if (restResponse.StatusCode == System.Net.HttpStatusCode.OK )
            {
                LoggerOutput.WriteLine("Verificação bem sucedida!");
                return JsonSerializer.Deserialize<Get_StoreOrder_Response>(restResponse.Content);
            }
            else
            {
                LoggerOutput.WriteLine("Verificação Falhou! Estava esperando o cod:" + System.Net.HttpStatusCode.OK + ",mas foi retornado:" + restResponse.StatusCode);
                return null;
            }

        }
        // Get Store Inventory
        public Get_AllStoreInventory_Response Get_AllStoreInventory()
        {
            // Criando o ResCliente
            RestClient restClient = new RestClient(); //Criar um cliente
            RestRequest restRequest = new RestRequest(Method.GET); // Criar uma requisição 
            IRestResponse restResponse;

            //Criando a url Base

            restClient.BaseUrl = new Uri(APIMethods.StoreInventory);

            //Executar

            restResponse = restClient.Execute(restRequest);

            //Verificação

            if(restResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                LoggerOutput.WriteLine("Verificação bem sucedida!");
                return JsonSerializer.Deserialize<Get_AllStoreInventory_Response>(restResponse.Content);
            }
            else
            {
                LoggerOutput.WriteLine("Verificação Falhou! Estava esperando o cod:"+ System.Net.HttpStatusCode.OK + ",mas foi retornado:"+ restResponse.StatusCode);
                return null;
            }
        }
    }
}
