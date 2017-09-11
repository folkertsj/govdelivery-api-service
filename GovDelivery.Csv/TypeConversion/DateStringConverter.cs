﻿using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using GovDelivery.Csv.Utils;

namespace GovDelivery.Csv.TypeConversion
{
    public class DateStringConverter : DefaultTypeConverter
    {
        public override object ConvertFromString(string text, IReaderRow row, MemberMapData propertyMapData)
        {
            var trimmed = text.Trim(new char[] { ' ', '"', '\n' });
            return TimeUtils.DateStringToDateTimeUtc(trimmed);
        }
    }
}