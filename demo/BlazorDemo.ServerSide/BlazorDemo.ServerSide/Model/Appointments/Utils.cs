﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Demo.Blazor.Model {

    public static class DateTimeUtils {
        public static DateTime CreateWeekStart() {
            return DateTime.Today.DayOfWeek == DayOfWeek.Sunday ? ValidWeekStart(DateTime.Today.Date) : ValidWeekStart(DateTime.Today.Date - CreateWeekOffset(DateTime.Today, DayOfWeek.Sunday));
        }

        static DateTime ValidWeekStart(DateTime date) {
            TimeSpan weekSpan = new TimeSpan(7, 0, 0, 0);
            DateTime baseDate = date.Date;

            if (DateTime.MaxValue - date < weekSpan)
                return baseDate - weekSpan;
            return baseDate;
        }
        static TimeSpan CreateWeekOffset(DateTime date, DayOfWeek firstDayOfWeek) {
            int offset = (date.DayOfWeek + 7 - firstDayOfWeek) % 7;
            TimeSpan result = TimeSpan.FromDays(offset);
            if (date.Ticks < result.Ticks)
                result = TimeSpan.FromDays(offset - 7);
            return result;
        }
    }

}
