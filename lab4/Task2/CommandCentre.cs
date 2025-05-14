using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class CommandCentre
    {
        private List<Aircraft> _waitingAircrafts = new List<Aircraft>(); // Літаки, які чекають на посадку
        private RunwayManager _runwayManager;

        public CommandCentre(RunwayManager runwayManager)
        {
            _runwayManager = runwayManager;
        }

        public void RequestLanding(Aircraft aircraft)
        {
            _waitingAircrafts.Add(aircraft); // Додаємо літак в чергу
            Console.WriteLine($"Aircraft {aircraft.Name} has requested landing.");

            // Якщо це перший літак в черзі, запускаємо процес посадки
            if (_waitingAircrafts.Count == 1)
            {
                ProcessLanding();
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is waiting for runway.");
            }
        }

        private async void ProcessLanding()
        {
            // Працюємо з чергою
            while (_waitingAircrafts.Count > 0)
            {
                var aircraft = _waitingAircrafts[0]; // Перший літак в черзі
                var runway = _runwayManager.GetAvailableRunway();

                if (runway != null)
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} is landing.");
                    _runwayManager.ReserveRunway(runway, aircraft); // Резервуємо смугу для літака
                    Console.WriteLine($"Aircraft {aircraft.Name} has landed.");
                    _waitingAircrafts.RemoveAt(0); // Видаляємо літак з черги

                    await Task.Delay(2000); // Затримка для імітації процесу посадки
                    Console.WriteLine($"Aircraft {aircraft.Name} is taking off.");
                    _runwayManager.ReleaseRunway(runway); // Вивільняємо смугу

                    // Після зльоту наступний літак автоматично може приземлитися
                    if (_waitingAircrafts.Count > 0)
                    {
                        Console.WriteLine("Processing next aircraft in queue.");
                        ProcessLanding(); // Якщо є літаки в черзі, намагаємося посадити наступний літак
                    }
                }
                else
                {
                    // Якщо немає вільної смуги, чекаємо
                    Console.WriteLine($"No available runway for Aircraft {aircraft.Name}. Waiting...");
                    await Task.Delay(1000); // Затримка перед новою спробою посадки
                }
            }
        }
    }
}
