using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace EleicaoBrasilApi.Models
{
    public class Candidato
    {
        public int Id {get; set; }
        public string Nome { get; set; }
        public string Partido { get; set; }
        public int Numero {get;set; }
    }
}