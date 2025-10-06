namespace ExtensionDateTime
{
    public static class DateTimeExtension
    {
        public static Seasons GetSeason(this DateTime date)
        {
            Seasons season = new Seasons();
            //se l'anno è bisestile sposto tutte le date di 1
            if (date.Year%4==0)
            {
                if (date.DayOfYear >= 81 || date.DayOfYear <= 172)
                {
                    season = Seasons.SPRING;
                }
                else if (date.DayOfYear >= 173 || date.DayOfYear <= 264)
                {
                    season = Seasons.SUMMER;
                }
                else if (date.DayOfYear >= 265 || date.DayOfYear <= 356)
                {
                    season = Seasons.AUTUMN;
                }
                else if (date.DayOfYear >= 357 || date.DayOfYear <= 80)
                {
                    season = Seasons.WINTER;
                }
            }
            else
            {
                if (date.DayOfYear >= 80 || date.DayOfYear <= 171)
                {
                    season = Seasons.SPRING;
                }
                else if (date.DayOfYear >= 172 || date.DayOfYear <= 263)
                {
                    season = Seasons.SUMMER;
                }
                else if (date.DayOfYear >= 264 || date.DayOfYear <= 355)
                {
                    season = Seasons.AUTUMN;
                }
                else if (date.DayOfYear >= 356 || date.DayOfYear <= 79)
                {
                    season = Seasons.WINTER;
                }
            }
            return season;
        }

        public static bool IsItACertainSeason(Seasons season, DateTime date)
        {
            {
                if (date.GetSeason() == season)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static int DaysUntilNextSeason(DateTime date)
        {
            int daysUntilNextSeason = 0;
            //controllo se l'anno è bisestile
            if(date.Year%4==0)
            {
                switch (date.GetSeason())
                {
                    case Seasons.SPRING:
                        daysUntilNextSeason = 173 - date.DayOfYear;
                        break;
                    case Seasons.SUMMER:
                        daysUntilNextSeason = 265 - date.DayOfYear;
                        break;
                    case Seasons.AUTUMN:
                        daysUntilNextSeason = 357 - date.DayOfYear;
                        break;
                    case Seasons.WINTER:
                        daysUntilNextSeason = (81 - date.DayOfYear) + 366;
                        break;
                }
            }
            else
            {
                switch (date.GetSeason())
                {
                    case Seasons.SPRING:
                        daysUntilNextSeason = 172 - date.DayOfYear;
                        break;
                    case Seasons.SUMMER:
                        daysUntilNextSeason = 264 - date.DayOfYear;
                        break;
                    case Seasons.AUTUMN:
                        daysUntilNextSeason = 356 - date.DayOfYear;
                        break;
                    case Seasons.WINTER:
                        daysUntilNextSeason = (80 - date.DayOfYear) + 365;
                        break;
                }
            }
            return daysUntilNextSeason;
        }
    }
}

