using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAPI
{
    internal class WeatherPesponse
    {
        public string Name { set; get; }
        public MainInfo Main { set; get; }
    }
    class MainInfo
    { 
        public float Temp { get; set; }
    }

}
