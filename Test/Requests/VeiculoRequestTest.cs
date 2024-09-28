using System.Net;
using System.Text;
using System.Text.Json;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.ModelViews;
using MinimalApi.DTOs;
using Test.Helpers;

namespace Test.Requests;

[TestClass]
public class VeiculoRequestTest
{
    [ClassInitialize]
    public static void ClassInit(TestContext testContext)
    {
        Setup.ClassInit(testContext);
    }

    [ClassCleanup]
    public static void ClassCleanup()
    {
        Setup.ClassCleanup();
    }
    
    [TestMethod]
    public async Task TestarGetSetPropriedades()
    {
        // Arrange
        var veiculoDTO = new VeiculoDTO{
            Nome = "Raptor",
            Marca = "Ford",
            Ano = 2022
        };

        var content = new StringContent(JsonSerializer.Serialize(veiculoDTO), Encoding.UTF8,  "Application/json");

        // Act WIP: logar antes de fazer POST
        var response = await Setup.client.PostAsync("/veiculos", content);

        // Assert

        // Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);

        // var result = await response.Content.ReadAsStringAsync();
        // var veiculoSalvo = JsonSerializer.Deserialize<Veiculo>(result, new JsonSerializerOptions
        // {
        //     PropertyNameCaseInsensitive = true
        // });

        // Assert.IsNotNull(veiculoSalvo?.Nome ?? "");
        // Assert.IsNotNull(veiculoSalvo?.Marca ?? "");
        // Assert.IsNotNull(veiculoSalvo?.Ano ?? null);
    }
}