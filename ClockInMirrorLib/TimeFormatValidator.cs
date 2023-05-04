// See https://aka.ms/new-console-template for more information
namespace ClockInMirrorLib;

public static class TimeFormatValidator
{
    // timeValue should be "HH:mm"   
    public static bool ValidateTimeFormat(string? timeValue, out int hours, out int minutes)
    {
        hours = -1;
        minutes = -1;

        if (string.IsNullOrEmpty(timeValue))
            return false;

        var arr = timeValue.Split(':');

        if (arr.Length != 2 || arr[0].Length != 2 || arr[1].Length != 2)
            return false;

        int i;
        if (int.TryParse(arr[0], System.Globalization.NumberStyles.Integer, null, out i)) {
            hours = i;
        } else {
            return false;
        }
        if (int.TryParse(arr[1], System.Globalization.NumberStyles.Integer, null, out i)) {
            minutes = i;
        } else {
            return false;
        }

        if (hours < 1 || hours > 12 || minutes < 0 || minutes > 59)
            return false;

        return true;
    }

    public static bool ValidateTimeFormat(string? timeValue)
    {
        int hours;
        int minutes;

        return ValidateTimeFormat(timeValue, out hours, out minutes);
    }
}