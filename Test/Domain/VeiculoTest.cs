using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        // Arrange
        var veiculo = new Veiculo
        {
            // Act
            Id = 1,
            Nome = "Marea",
            Marca = "Fiat",
            Ano = 2010
        };

        // Assert
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Marea", veiculo.Nome);
        Assert.AreEqual("Fiat", veiculo.Marca);
        Assert.AreEqual(2010, veiculo.Ano);
    }
}