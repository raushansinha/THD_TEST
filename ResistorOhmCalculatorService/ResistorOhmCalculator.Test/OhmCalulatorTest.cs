using ResistorOhmCalculator.BO;
using ResistorOhmCalculator.DTO.Request;
using System;
using Xunit;

namespace ResistorOhmCalculator.Test
{
    public class OhmCalulatorTest
    {
        private readonly IOhmValueCalculator _OhmValueCalculator;

        public OhmCalulatorTest()
        {
            _OhmValueCalculator = new OhmValueCalculator();
        }

        [Fact]
        public void CalculateOhmValueForAllBlackIsZero()
        {
            int result = _OhmValueCalculator.CalculateOhmValue(Convert.ToString((int)BandColor.Black),
                                                               Convert.ToString((int)BandColor.Black),
                                                               Convert.ToString((int)BandColor.Black),
                                                               Convert.ToString((int)BandColor.Black));

            Assert.True(result.Equals(0));
        }

        [Fact]
        public void CalculateOhmValueForAllYellowVioletRedIs4700()
        {
            int result = _OhmValueCalculator.CalculateOhmValue(Convert.ToString((int)BandColor.Yellow),
                                                               Convert.ToString((int)BandColor.Violet),
                                                               Convert.ToString((int)BandColor.Red),
                                                               Convert.ToString((int)BandColor.Black));

            Assert.True(result.Equals(4700));
        }

        [Fact]
        public void CalculateOhmValueForAllBrownWhiteOrangeIs19000()
        {
            int result = _OhmValueCalculator.CalculateOhmValue(Convert.ToString((int)BandColor.Brown),
                                                               Convert.ToString((int)BandColor.White),
                                                               Convert.ToString((int)BandColor.Orange),
                                                               Convert.ToString((int)BandColor.Black));

            Assert.True(result.Equals(19000));
        }
    }
}
