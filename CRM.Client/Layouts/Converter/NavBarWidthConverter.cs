using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Client.Layouts.Converter
{
    /// <summary>
    /// Resize width của nav bar theo trạng thái hiện tại của nav bar
    /// </summary>
    public class NavBarWidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isLarge)
            {
                return isLarge ? 64 : 84; // Large size: 160px, Small size: 80px
            }
            return 84; // Default to small if not a boolean
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
