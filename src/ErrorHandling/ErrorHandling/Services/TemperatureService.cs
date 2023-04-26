﻿using ErrorHandling.Exceptions;

namespace ErrorHandling.Services
{
    public class TemperatureService
    {
        public int GetTemperature(int l, int r)
        {
            if (l > r)
            {
                throw new ForecastTemperatureRangeException($"bad args {nameof(l)} {nameof(r)}");
            }

            if (Random.Shared.Next(2) == 0)
            {
                throw new UnluckyException("whoops");
            }

            return Random.Shared.Next(l, r);
        }
    }
}
