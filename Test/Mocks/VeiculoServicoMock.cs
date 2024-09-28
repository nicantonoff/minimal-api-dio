using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;

namespace Test.Mocks;

public class VeiculoServicoMock : IVeiculoServico
{
    private static List<Veiculo> veiculos =
    [
        new Veiculo
        {
            Id = 1,
            Nome = "Tem 4 rodas",
            Marca = "Chinesa",
            Ano = 2022
        },
        new Veiculo
        {
            Id = 2,
            Nome = "Também tem 4 rodas",
            Marca = "BYD",
            Ano = 2024
        }
    ];

    public void Apagar(Veiculo veiculo)
    {
        throw new NotImplementedException();
    }

    public void Atualizar(Veiculo veiculo)
    {
        throw new NotImplementedException();
    }

    public void Incluir(Veiculo veiculo)
    {
        veiculo.Id = veiculos.Count + 1;
        veiculos.Add(veiculo);
    }

    public List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null)
    {
        return veiculos;
    }

    Veiculo? IVeiculoServico.BuscaPorId(int id)
    {
        return veiculos.Find(v => v.Id == id);
    }
}
