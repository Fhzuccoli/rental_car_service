using System.Globalization;

namespace AluguelCarroServico.Entities
{
    class OrdemServico
    {
        public double PagamentoPadrao { get; set; }
        public double Imposto { get; set; }

        public OrdemServico(double pagamentoPadrao, double imposto)
        {
            PagamentoPadrao = pagamentoPadrao;
            Imposto = imposto;
        }

        public double PagamentoTotal
        {
            get { return PagamentoPadrao + Imposto; }
        }

        public override string ToString()
        {
            return "Basic payment: "
                + PagamentoPadrao.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Imposto.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
