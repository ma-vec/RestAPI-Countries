using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meteo_API_net
{
    internal class Daily
    {
        public string[] time;
        public float[] temperature_2m_max;
        public float[] temperature_2m_min;
        public float[] precipitation_sum;
    }
}
