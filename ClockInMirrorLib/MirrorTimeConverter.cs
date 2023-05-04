// See https://aka.ms/new-console-template for more information
namespace ClockInMirrorLib;

public static class MirrorTimeConverter
{
    public static string WhatIsTheTime(string? mirrorTime)
    {
        int hours;
        int minutes;

        if (!TimeFormatValidator.ValidateTimeFormat(mirrorTime, out hours, out minutes)) {
            throw new InvalidDataException(
                string.Concat("invalid time: '", mirrorTime ?? string.Empty, "'"));
        }

        var hoursMirrored = GetMirroredHours(hours, (minutes == 0));
        var minutesMirrored = GetMirroredMinutes(minutes);
        
        return string.Concat(hoursMirrored.ToString("00"), ":", minutesMirrored.ToString("00"));
    }

    // ATTENTION: kata forbids hour is 0 -> hour is 12
    // hours (if minutes == 0)
    //   12 <-> 12, 01 <-> 11, 02 <-> 10
    //   03 <-> 09, 04 <-> 08, 05 <-> 07, 06 <-> 06
    // hours (if minutes != 0)
    //   12 <-> 11, 01 <-> 10, 02 <-> 09
    //   03 <-> 08, 04 <-> 07, 05 <-> 06
    private static int GetMirroredHours(int hours, bool minutesIsNull) {
        // calculating is much easier with 0 instead of 12
        if (hours == 12)
            hours = 0;

        int result;
        
        if (minutesIsNull) {
            result = 12 - hours;
        } else {
            result = 11 - hours;
        }

        // due to the kata-restrictions...
        if (result == 0)
            result = 12;
        
        return result;
    }

    private static int GetMirroredMinutes(int minutes) {
        // minutes
        //   00 <-> 00, 01 <-> 59, 02 <-> 58, ...

        // 0 would break the calculation (could set minutes to 60 instead of return 0 directly)
        if (minutes == 0)
            return 0;

        // thats it
        return 60 - minutes;
    }
}