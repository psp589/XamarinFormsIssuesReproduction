using System;
using System.Globalization;
using Xamarin.Forms;


namespace XamarinSamples.Converters
{
    public class BoolToHeight : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((bool)value)
                {
                    return System.Convert.ToDouble((string)parameter);
                }
                else return 0;
            }
            else
                return 0;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((double)value == System.Convert.ToDouble((string)parameter)) return true;
            else return false;
        }
    }
}
