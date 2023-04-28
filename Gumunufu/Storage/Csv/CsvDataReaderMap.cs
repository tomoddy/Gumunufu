using CsvHelper.Configuration;
using Gumunufu.Globals;
using Gumunufu.Objects;
using System.Globalization;

namespace Gumunufu.Storage.Csv
{
    /// <summary>
    /// Data reader map
    /// </summary>
    internal sealed class CsvDataReaderMap : ClassMap<Transaction>
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        internal CsvDataReaderMap()
        {
            Map(m => m.Date).TypeConverterOption.Format(Resource.Argument.SHORT_DATE).TypeConverterOption.CultureInfo(CultureInfo.InvariantCulture).Index(0);
            Map(m => m.Account).Index(1);
            Map(m => m.Name).Index(2);
            Map(m => m.Amount).Index(3);
            Map(m => m.Category).Index(4);
        }
    }
}