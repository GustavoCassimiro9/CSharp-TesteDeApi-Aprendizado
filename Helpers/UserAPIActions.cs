using System;
using Xunit.Abstractions;
using RestSharp;
using System.Text.Json;
using AutomacaoPetStore.Models;
namespace AutomacaoPetStore.Helpers
{
    public class UserAPIActions
    {
        private ITestOutputHelper LoggerOutput;

        public ITestOutputHelper Logger
        {
            get { return LoggerOutput; }
            set { LoggerOutput = value; }
        }
        public UserAPIActions(ITestOutputHelper LoggerOutput)
        {
            this.LoggerOutput = LoggerOutput;
        }
        public Get_UserName_Response Get_UserName(string username)//End Point com parametro
        {
            // Criando o ResCliente
            RestClient restClient = new RestClient(); //Criar um cliente
            RestRequest restRequest = new RestRequest(Method.GET); // Criar uma requisição 
            IRestResponse restResponse;

            restClient.BaseUrl = new Uri(APIMethods.UserName + username);
            restResponse = restClient.Execute(restRequest);

            if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                LoggerOutput.WriteLine("Verificação bem sucedida!");
                return JsonSerializer.Deserialize<Get_UserName_Response>(restResponse.Content);
            }
            else
            {
                LoggerOutput.WriteLine("Verificação Falhou! Estava esperando o cod:" + System.Net.HttpStatusCode.OK + ",mas foi retornado:" + restResponse.StatusCode);
                return null;
            }

        }
    }
}
