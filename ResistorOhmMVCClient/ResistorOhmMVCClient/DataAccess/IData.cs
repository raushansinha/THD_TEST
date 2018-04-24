using ResistorOhmMVCClient.DTO.Request;
using ResistorOhmMVCClient.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ResistorOhmMVCClient.DataAccess
{
    public interface IData
    {
        /// <summary>
        /// Get the Ohm value of a resistor based on the selected band colors.
        /// </summary>
        /// <param name="bandAColor">The color of the first figure of component value band.</param>
        /// <param name="bandBColor">The color of the second significant figure band.</param>
        /// <param name="bandCColor">The color of the decimal multiplier band.</param>
        /// <param name="bandDColor">The color of the tolerance value band.</param>
        Task<ResistorOhmResponse> GetResistorOhmValue(ResistorOhmRequest request);

    }
}
