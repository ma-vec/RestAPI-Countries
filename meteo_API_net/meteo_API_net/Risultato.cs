using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meteo_API_net
{
    internal class Risultato
    {
        public float latitude;
        public float longitude;
        public float generationtime_ms;
        public float utc_offset_seconds;
        public string timezone;
        public string timezone_abbreviation;
        public float elevation;
        public Daily daily;
        public DailyUnits dailyUnits;
    }
}
