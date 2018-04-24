using ResistorOhmCalculator.BO;
using ResistorOhmCalculator.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResistorOhmCalculator.Model
{
    public class OhmCalculatorModel
    {

        private readonly IOhmValueCalculator _OhmValueCalculator;

        public OhmCalculatorModel(IOhmValueCalculator ohmValueCalculator)
        {
            _OhmValueCalculator = ohmValueCalculator;
        }

        public int GetOhmValue(OhmRequest request)
        {
            return _OhmValueCalculator.CalculateOhmValue(Convert.ToString((int)request.bandAColor),
                                                         Convert.ToString((int)request.bandBColor),
                                                         Convert.ToString((int)request.bandCColor),
                                                         Convert.ToString((int)request.bandDColor));
        }
    }
}
