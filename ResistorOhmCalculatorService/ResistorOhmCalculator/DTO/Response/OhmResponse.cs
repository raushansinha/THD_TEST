using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResistorOhmCalculator.DTO.Response
{
    public class OhmResponse
    {
        public int Ohm { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
    }
}
