using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;


namespace meteo_API_net
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://api.open-meteo.com/v1/forecast?latitude=41.9028&longitude=12.4964&daily=temperature_2m_max,temperature_2m_min,precipitation_sum&timezone=auto&authuser=0");
            HttpResponseMessage response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string risp = await response.Content.ReadAsStringAsync();
            Risultato oggetto = JsonConvert.DeserializeObject<Risultato>(risp);
            //MessageBox.Show(oggetto.elevation.ToString());
            for (int i = 0; i < oggetto.daily.temperature_2m_max.Length; i++)
            {
                chart2.Series[0].Points.AddXY(oggetto.daily.time[i], oggetto.daily.temperature_2m_max[i]);
            }

        }
    }
}
