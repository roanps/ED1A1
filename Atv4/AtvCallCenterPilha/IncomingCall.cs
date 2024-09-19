using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtvCallCenterPilha
{
    //Esta classe representa a fila de chamados em um CallCenter
    public class IncomingCall
    {   
        //Escreve prop que já completa a linha abaixa SNIPED
        public int Id { get; set; }
        public int ClientId { get; set; }

        public DateTime CallTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }    
        public string? Consultant { get; set; }
    }
}