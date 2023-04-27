using CsvHelper.Configuration;
using Gumunufu.Objects;
using System.Globalization;

namespace Gumunufu.Helpers
{
    /// <summary>
    /// Data reader map
    /// </summary>
    internal sealed class DataReaderMap : ClassMap<Transaction>
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        internal DataReaderMap()
        {
            Map(m => m.Date).TypeConverterOption.Format(Config.SHORT_DATE).TypeConverterOption.CultureInfo(CultureInfo.InvariantCulture).Index(0);
            Map(m => m.Account).Index(1);
            Map(m => m.Name).Index(2);
            Map(m => m.Amount).Index(3);
            Map(m => m.Category).Index(4);
        }
    }
}