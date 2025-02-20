using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Client.Layouts.Converter
{
    /// <summary>
    /// Chỉnh lại position của nav header theo vị trí hiện tại của nav bar
    /// </summary>
    public class ProfilePositionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isLarge)
            {
                return isLarge ? new Thickness(56,0,0,0) : new Thickness(0, 0, 12, 0); // Large size: 160px, Small size: 80px
            }
            return 84; // Default to small if not a boolean
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
