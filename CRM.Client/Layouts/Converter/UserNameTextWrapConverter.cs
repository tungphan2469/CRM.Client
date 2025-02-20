using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Client.Layouts.Converter
{
    /// <summary>
    /// Resize width của username để textwrap khi nav bar ở trạng thái compact
    /// </summary>
    public class UserNameTextWrapConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isCompactMode)
            {
                return isCompactMode ? double.PositiveInfinity : 64; // Set small width in Compact Mode
            }
            return 64;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
