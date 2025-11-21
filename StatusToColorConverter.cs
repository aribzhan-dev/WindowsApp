using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Globalization;

namespace HelloAvalonia;

public class StatusToColorConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value is string s
            ? s switch
              {
                  "Done" => new SolidColorBrush(Colors.LightGreen),
                  "Active" => new SolidColorBrush(Color.Parse("#90CAF9")),
                  _ => new SolidColorBrush(Color.Parse("#90CAF9"))
              }
            : new SolidColorBrush(Color.Parse("#90CAF9"));
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        => throw new NotSupportedException();
}