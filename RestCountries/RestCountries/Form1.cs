using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace RestCountries
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string name = textBox.Text;
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"https://restcountries.com/v3.1/name/{name}");
            HttpResponseMessage response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();
            var countries = JsonConvert.DeserializeObject<List<State.Root>>(result);

            var country = countries[0];

            if (country != null || country.capital != null && name.Length > 2)
            {
                string capital = country.capital[0];
                label1.Text = capital;
            }
            else
            {
                label1.Text="Capitale non trovata.";
            }

        }
    }
}
