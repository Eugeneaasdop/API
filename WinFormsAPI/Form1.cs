using System.Net;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace WinFormsAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=London&appid=0af7f0fb583a9819ef4f5892bdfbcc98&ubits=metric";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader= new StreamReader(res.GetResponseStream());
            string response = reader.ReadToEnd();
            richTextBox1.Text = response;
            WeatherPesponse wr = JsonConvert.DeserializeObject<WeatherPesponse>(response);
            City.Text = wr.Name;
            Temperatura.Text = wr.Main.Temp.ToString();
        }
    }
}