namespace ClockApp
{
    public static class ClockCalculator
    {
        public static int CalculateAngle(int hours, int minutes)
        {
            var hoursDeg = CalculatePositionHours(hours);

            var minsDeg = CalculatePositionMinutes(minutes);

            var result = Math.Abs(minsDeg - hoursDeg);


            if (result > 180)
            {
                result = 360 - result;
            }

            return result;
        }

        private static int CalculatePositionHours(int hours)
        {
            var hourToDegrees = hours * 30;

            if (hours == 12)
            {
                hourToDegrees = 0;
            }
            
            return hourToDegrees;
        }

        private static int CalculatePositionMinutes(int minutes)
        {
            var minutesToDegrees = minutes * 6;

            if (minutes == 0)
            {
                minutesToDegrees = 0;
            }

            return minutesToDegrees;
        }
    }
}
