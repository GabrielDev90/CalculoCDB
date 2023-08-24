using CalculoCDB.ModuloCalculos.CalculoCDB;

namespace CalculoCBD.Teste
{
    public class Tests
    {
        CalculaCDBServico calculaCDB;

        [SetUp]
        public void Setup()
        {
            calculaCDB = new CalculaCDBServico();
        }

        [Test]
        [TestCase(108, 0.9, 0.00972)]
        public void Faz_O_Calculo_CDI_Com_TB_Para_Saber_O_Percentual_Pago_Pelo_Banco(double CDI, double TB, decimal percentualPagoEsperado)
        {
            var percentualPago = calculaCDB.CalculaValorPagoSobreCDI(CDI, TB);
            Assert.That(percentualPago, Is.EqualTo(percentualPagoEsperado));
        }

        [Test]
        [TestCase(6, 22.5)]
        [TestCase(11, 20)]
        [TestCase(12, 20)]
        [TestCase(13, 17.5)]
        [TestCase(24, 17.5)]
        [TestCase(25, 15)]
        public void Verificar_Valores_Tabela_Do_Imposto_De_Renda_Por_Mes(int meses, double impostoPercentualCobrado)
        {
            var impostoRendaTabela = calculaCDB.RetornaTabelaImpostoDeRenda(meses);
            Assert.That(impostoRendaTabela, Is.EqualTo(impostoPercentualCobrado));
        }

        [Test]
        [TestCase(1, 0.00972, 1000, 1009.72)]
        public void Calcula_Valor_Brunto_Baseado_No_Valor_Investido_Com_Percentual_Pago_Pelo_Banco(int quantidadeMeses, double percentualPagoPeloBanco, double valorInicial, double valorFinalEsperado)
        {
            var valorFinal = calculaCDB.CalculaValorBrunto(quantidadeMeses, percentualPagoPeloBanco, valorInicial);
            Assert.That(valorFinal, Is.EqualTo(valorFinalEsperado));
        }

        [Test]
        [TestCase(1097.2, 22.5, 246.87)]
        public void Calcula_Valor_Liquido_Aplicando_Desconto_Imposto_De_Renda(double valorFinal, double percentualImpostoDeRenda, double valorDesconto)
        {
            var final = calculaCDB.CalculaValorDescontadoImpostoDeRenda(valorFinal, percentualImpostoDeRenda);
            Assert.That(final, Is.EqualTo(valorDesconto));
        }


        [Test]
        [TestCase(1000, 200, 800)]
        public void Calcula_Valor_Liquido(double valorFinal, double valorDesconto, double valorEsperando)
        {
            var valorLiquido = calculaCDB.CalculaValorLiquido(valorFinal, valorDesconto);
            Assert.That(valorLiquido, Is.EqualTo(valorEsperando));
        }

        [Test]
        [TestCase(1000, 200, 800)]
        public void Calcula_Valor_Liquido_(double valorFinal, double valorDesconto, double valorEsperando)
        {
            var valorLiquido = calculaCDB.CalculaValorLiquido(valorFinal, valorDesconto);
            Assert.That(valorLiquido, Is.EqualTo(valorEsperando));
        }


        //[Test]
        //[TestCase(1000, 200, 800)]
        //public void Teste_Integracao(double valorFinal, double valorDesconto, double valorEsperando)
        //{
        //    var percentualPago = calculaCDB.CalculaValorPagoSobreCDI(ValorTB, ValorCDI);

        //    var valorBruto = calculaCDB.CalculaValorBrunto(quantidadeMeses, percentualPago, valorInicial);

        //    var percentualImpostoDeRenda = calculaCDB.RetornaTabelaImpostoDeRenda(quantidadeMeses);

        //    var valorImpostoPagar = calculaCDB.CalculaValorDescontadoImpostoDeRenda(valorBruto, percentualImpostoDeRenda);

        //    var valorLiquido = calculaCDB.CalculaValorLiquido(valorBruto, valorImpostoPagar);
        //    Assert.That(valorLiquido, Is.EqualTo(valorEsperando));
        //}
    }
}