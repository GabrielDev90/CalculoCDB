using CalculoCDB.Dominio;
using CalculoCDB.ModuloCalculos.CalculoCDB;

namespace CalculoCDB.Aplicaca.Servicos
{
    public class ResgateAplicacaoServico : IResgateAplicacaoServico
    {
        private readonly ICalculaCDBServico calculaCDBServico;
        private double ValorTB { get; set; }
        private double ValorCDI { get; set; }

        public ResgateAplicacaoServico(ICalculaCDBServico calculaCDBServico)
        {
            ValorTB = 108;
            ValorCDI = 0.9;
            this.calculaCDBServico = calculaCDBServico;
        }

        public ResgateAplicacao RetornaEstimativaCalculoCDB(double valorInicial, int quantidadeMeses)
        {
            var percentualPago = calculaCDBServico.CalculaValorPagoSobreCDI(ValorTB, ValorCDI);

            var valorBruto = calculaCDBServico.CalculaValorBrunto(quantidadeMeses, percentualPago, valorInicial);

            var percentualImpostoDeRenda = calculaCDBServico.RetornaTabelaImpostoDeRenda(quantidadeMeses);

            var valorImpostoPagar = calculaCDBServico.CalculaValorDescontadoImpostoDeRenda(valorBruto, percentualImpostoDeRenda);

            var valorLiquido = calculaCDBServico.CalculaValorLiquido(valorBruto, valorImpostoPagar);

            return new ResgateAplicacao { ValorBruto = valorBruto, ValorLiquido = valorLiquido };
        }
    }
}