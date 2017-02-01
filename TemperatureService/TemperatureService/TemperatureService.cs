using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace TemperatureService
{
    public class TemperatureService: ITemperatureService
    {
        public string getTemperature()
        {
            XDocument output = new XDocument();
            HttpWebRequest http = (HttpWebRequest)WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q=[LOCATION VALUE]&appid=5a4e086cd72628bca4015adbe80aecad&units=metric");
            WebResponse response = http.GetResponse();


            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string content = sr.ReadToEnd();

            //I could use better XDocument or JSonDeserializer

            return content;
        }
    }
}
