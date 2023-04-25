using Gumunufu.Objects;

namespace Gumunufu.Helpers
{
    /// <summary>
    /// Colour calculator
    /// </summary>
    internal class ColourCalculator
    {
        /// <summary>
        /// Bit range
        /// </summary>
        private const int RANGE = 255;

        /// <summary>
        /// Min value
        /// </summary>
        internal float MinValue { get; set; }

        /// <summary>
        /// Max value
        /// </summary>
        internal float MaxValue { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        internal ColourCalculator(float minValue, float maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }

        /// <summary>
        /// Get colour of cell
        /// </summary>
        /// <param name="cellValue">Value</param>
        /// <returns>Colour</returns>
        internal Color GetColour(object cellValue)
        {
            float value = ((CellData)cellValue).Total;

            int r, g, b;
            r = g = b = RANGE;
            if (value < 0)
                b = g -= (int)(RANGE * (Math.Abs(value) / Math.Abs(MinValue)));
            if (value > 0)
                b = r -= (int)(RANGE * (Math.Abs(value) / Math.Abs(MaxValue)));

            return Color.FromArgb(r, g, b);
        }
    }
}