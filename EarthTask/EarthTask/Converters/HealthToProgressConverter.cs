﻿using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace EarthTask.Converters
{
    public class HealthToProgressConverter : IValueConverter
    {
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is int health)
            {
                return (double)health / 100.0;
            }

            return 1.0;
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
