using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double holydays = double.Parse(Console.ReadLine());
            double weekends = double.Parse(Console.ReadLine());

            double weekendsInSofia = 48 - weekends;
            double weekendsInSofia2 = weekendsInSofia * 3 / 4;
            double gamesInSofiaHolydays = holydays * 2 / 3;
            double allGamesInSofiaAndHomeCity = weekendsInSofia2 + weekends + gamesInSofiaHolydays;
            double volleyballGames = allGamesInSofiaAndHomeCity * 0.15;
            double allGamesForYear = volleyballGames + allGamesInSofiaAndHomeCity;

            if (year == "leap")
            {
                Console.WriteLine(Math.Truncate(allGamesForYear));
            }
            else if (year == "normal")
            {
                Console.WriteLine(Math.Truncate(allGamesInSofiaAndHomeCity));
            }
        }
    }
}
