using ResistorOhmCalculator.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResistorOhmCalculator.BO
{
    public class OhmValueCalculator : IOhmValueCalculator
    {
        public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {

            return Convert.ToInt32(bandAColor + bandBColor.PadRight(Convert.ToInt32(bandCColor) + 1 , '0'));
        }
    }
}
