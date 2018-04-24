using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResistorOhmCalculator.DTO.Request
{
    public class OhmRequest
    {
        public  BandColor bandAColor { get; set; }
        public BandColor bandBColor { get; set; }
        public BandColor bandCColor { get; set; }
        public BandColor bandDColor { get; set; }

    }

    /// <summary>
    /// -3: Pink
    /// </summary>
    public enum BandColor
    {
        Pink = -3,
        Silver,
        Gold,
        Black,
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
