using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class RunwayManager
    {
        private List<Runway> _runways;

        public RunwayManager(List<Runway> runways)
        {
            _runways = runways;
        }

        public Runway? GetAvailableRunway()
        {
            // Пошук вільної смуги
            foreach (var runway in _runways)
            {
                if (runway.IsBusyWithAircraft == null)
                {
                    return runway;
                }
            }
            return null; // Якщо всі смуги зайняті
        }

        public void ReserveRunway(Runway runway, Aircraft aircraft)
        {
            runway.IsBusyWithAircraft = aircraft;
            runway.HighLightRed(); // Вибір смуги для посадки
        }

        public void ReleaseRunway(Runway runway)
        {
            runway.IsBusyWithAircraft = null;
            runway.HighLightGreen(); // Вивільнення смуги
        }
    }
}

