using System;
using System.Linq;

namespace Sausio_24_d_pamoka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TV_Programme tV_Programme = new TV_Programme();

            TV_Show tV_Show1 = new TV_Show();
            tV_Show1.ID = Guid.NewGuid();
            tV_Show1.Title = "Talents";
            tV_Show1.Description = "Description";
            tV_Show1.StartTime = DateTime.Now.AddDays(-7);
            TimeSpan interval = tV_Show1.Duration - tV_Show1.StartTime;
            tV_Show1.Duration = interval;

            DateTime xmas = new DateTime(2009, 12, 25);
double daysUntilChristmas = xmas.Subtract(DateTime.Today).TotalDays;

            TV_Show tV_Show2 = new TV_Show();
            tV_Show2.ID = Guid.NewGuid();
            tV_Show2.Duration = DateTime.Now.Date;
            tV_Show2.Title = "Legends";
            tV_Show2.Description = "Description";
            tV_Show2.StartTime = DateTime.Now.AddDays(-14);

            TV_Programme programme = new TV_Programme();
            programme.TV_Shows.Add(tV_Show1);
        }
    }
}
