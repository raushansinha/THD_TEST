using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResistorOhmMVCClient.DTO.Response
{
    public class ResistorOhmResponse
    {
        public bool Success { get; set; }
        public int Ohm { get; set; }
        public string Error { get; set; }
  }
}
