using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace TestingWPFProject
{
    public class BoolToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isChecked = (bool)value;
            string imagePath = isChecked ? "Resources/checked_toggle.png" : "Resources/unchecked_toggle.png";
            return new BitmapImage(new Uri(imagePath, UriKind.Relative));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
