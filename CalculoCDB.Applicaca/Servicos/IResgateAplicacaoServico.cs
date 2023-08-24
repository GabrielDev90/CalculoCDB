using CalculoCDB.Dominio;

namespace CalculoCDB.Aplicaca.Servicos
{
    public interface IResgateAplicacaoServico
    {
        ResgateAplicacao RetornaEstimativaCalculoCDB(double ValorInicial, int Meses);
    }
}