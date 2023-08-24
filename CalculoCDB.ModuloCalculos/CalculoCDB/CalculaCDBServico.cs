using CalculoCDB.Dominio;
using System;
using System.Diagnostics.Metrics;

namespace CalculoCDB.ModuloCalculos.CalculoCDB
{
    public class CalculaCDBServico : ICalculaCDBServico
    {
        public double CalculaValorPagoSobreCDI(double valorTB, double valorCDI)
        {
            double valorMultiplicaPercentual = (valorTB * valorCDI) / 10000;
            return valorMultiplicaPercentual;
        }

        public double RetornaTabelaImpostoDeRenda(int QuantidadeMeses)
        {
            if (QuantidadeMeses <= 6)
            {
                return 22.5;
            }

            if (QuantidadeMeses > 6 && QuantidadeMeses <= 12)
            {
                return 20;
            }

            if (QuantidadeMeses > 12 && QuantidadeMeses <= 24)
            {
                return 17.5;
            }

            return 15;

        }

        public double CalculaValorBrunto(int quantidadeMeses, double percentualPagar, double valorInicial)
        {
            double valorMesAcumulado = valorInicial;

            for (int i = 0; i < quantidadeMeses; i++)
            {
                valorMesAcumulado = (Math.Round(valorMesAcumulado * (1 + percentualPagar), 2, MidpointRounding.ToEven));
            }

            return valorMesAcumulado;
        }

        public double CalculaValorLiquido(double valorBruto, double valorImpostoRenda)
        {
            return Math.Round(valorBruto - valorImpostoRenda, 2, MidpointRounding.ToEven);
        }

        public double CalculaValorDescontadoImpostoDeRenda(double valorFinal, double percentualImpostoDeRenda)
        {
            return Math.Round(valorFinal * percentualImpostoDeRenda / 100, 2, MidpointRounding.ToEven);
        }
    }
}