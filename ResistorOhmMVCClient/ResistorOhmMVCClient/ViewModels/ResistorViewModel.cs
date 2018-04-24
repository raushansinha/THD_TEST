using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResistorOhmMVCClient.ViewModel
{
    public class ResistorViewModel
    {

        public BandColor bandAColor { get; set; }
        public BandColor bandBColor { get; set; }
        public BandColor bandCColor { get; set; }
        public BandColor bandDColor { get; set; }
        public string btnResistorOhm { get; set; }

        public string Ohm { get; set; }

        public string Error { get; set; }

    }

    public enum BandColor
    {
        Black = 0,
        Brown,
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Violet,
        Gray,
        White
    }
}
