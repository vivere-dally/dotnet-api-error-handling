namespace ErrorHandling.Services
{
    public class TemperatureService
    {
        public int GetTemperature(int l, int r)
        {
            if (l > r)
            {
                throw new ArgumentException("bad arg", nameof(l));
            }

            if (Random.Shared.Next(2) == 0)
            {
                throw new Exception("whoops");
            }

            return Random.Shared.Next(l, r);
        }
    }
}
