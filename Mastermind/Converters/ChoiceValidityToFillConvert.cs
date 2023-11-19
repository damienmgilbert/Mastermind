using System;
using System.Globalization;
using System.Linq;
using Mastermind.Models;

namespace Mastermind.Converters;

public class ChoiceValidityToFillConvert : IValueConverter
{

    #region Public methods
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not ChoiceValidity choice)
        {
            return Brush.Transparent;
        }

        switch (choice)
        {
            case ChoiceValidity.NotPresent:
                {
                    return Brush.Transparent;
                }
            case ChoiceValidity.Present:
                {
                    return Brush.Orange;
                }
            case ChoiceValidity.PresentAndInPosition:
                {
                    return Brush.Green;
                }
            default:
                {
                    return Brush.Transparent;
                }
        }
    }
    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
    #endregion

}