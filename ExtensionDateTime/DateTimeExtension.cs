namespace ExtensionDateTime
{
    public static class DateTimeExtension
    {
        public static Seasons GetSeason(this DateTime date)
        {
            Seasons season = new Seasons();
            if(date.DayOfYear >= 80 || date.DayOfYear <=171)
            {
                season = Seasons.SPRING;
            }
            else if (date.DayOfYear >= 172 ||  date.DayOfYear <= 263)
            {
                season = Seasons.SUMMER;
            }
            else if (date.DayOfYear >= 264 || date.DayOfYear <= 355)
            {
                season = Seasons.AUTUMN;
            }
        }
    }
}
