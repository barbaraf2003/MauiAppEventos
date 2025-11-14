using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; } = string.Empty;
        public string Local { get; set; } = string.Empty;
        public int NumeroParticipantes { get; set; }
        public double CustoPorParticipante { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }

        // Propriedade calculada: duração em dias
        public int DuracaoEmDias
        {
            get
            {
                TimeSpan ts = DataTermino - DataInicio;
                return ts.Days;
            }
        }

        // Propriedade calculada: custo total
        public double CustoTotal
        {
            get
            {
                return NumeroParticipantes * CustoPorParticipante;
            }
            }
        }
}
