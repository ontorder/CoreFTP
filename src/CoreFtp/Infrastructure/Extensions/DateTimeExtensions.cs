﻿using System;

namespace CoreFtp.Infrastructure.Extensions
{
    public static class DateTimeExtensions
    {
        public static bool HasIntervalExpired(this DateTime lastActivity, DateTime now, int interval)
        {
            return interval > 0 && now.Subtract(lastActivity).TotalMilliseconds > interval;
        }
    }
}
