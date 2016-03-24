using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    interface IWeatherObserver
    {
        void Update(Object o);
        void Display();
    }
}
