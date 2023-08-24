using CalculoCDB.Dominio;

namespace CalculoCDB.ModuloCalculos.CalculoCDB
{
    public interface ICalculaCDBServico
    {
        double CalculaValorBrunto(int quantidadeMeses, double percentualPagar, double valorInicial);
        double CalculaValorDescontadoImpostoDeRenda(double valorFinal, double percentualImpostoDeRenda);
        double CalculaValorLiquido(double valorBruto, double valorImpostoRenda);
        double CalculaValorPagoSobreCDI(double ValorTB, double ValorCDI);
        double RetornaTabelaImpostoDeRenda(int QuantidadeMeses);
        //ResgateAplicacao RetornaValorLiquidoBrutoBasedoPorMeses(int quantidadeMeses, double ValorTB, double ValorCDI, double valorInicial);
    }
}