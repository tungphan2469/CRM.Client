using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.UI;

namespace CRM.Client.Layouts.Converter
{
    public class ProfileImageMarginConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isLarge)
            {
                return isLarge ? new Thickness(0, 46, 0, 0) : new Thickness(0, 26, 0, 0); // Large size: 160px, Small size: 80px
            }
            return new Thickness(0, 26, 0, 0); // Default to small if not a boolean
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
