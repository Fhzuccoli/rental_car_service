using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelCarroServico.Entities
{
    class AluguelCarro
    {
        public DateTime Comeco { get; set; }
        public DateTime Fim { get; set; }
        public Veiculo Veiculo { get; private set; }
        public OrdemServico OrdemServico { get; set; }

        public AluguelCarro(DateTime comeco, DateTime fim, Veiculo veiculo, OrdemServico ordemServico)
        {
            Comeco = comeco;
            Fim = fim;
            Veiculo = veiculo;
            OrdemServico = ordemServico;
        }
    }
}
