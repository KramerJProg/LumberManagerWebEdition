using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LumberManagerWebEdition.Models
{
    public class GetWeather
    {
        public static WeatherAPI weather;
        public GetWeather()
        {
            weather = GetWeatherAPI();
        }

        private WeatherAPI GetWeatherAPI()
        {
            string appId = "392e56b744423e17e9d6abc97ab0175b";
            string city = "Tacoma";
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&cnt=1&APPID={1}", city, appId);
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                RootObject weatherInfo = (new JavaScriptSerializer()).Deserialize<RootObject>(json);

                //Special VIEWMODEL design to send only required fields not all fields which received from   
                //www.openweathermap.org api  
                WeatherAPI rslt = new WeatherAPI();

                rslt.Country = weatherInfo.sys.country;
                rslt.City = weatherInfo.name;
                rslt.Lat = Convert.ToString(weatherInfo.coord.lat);
                rslt.Lon = Convert.ToString(weatherInfo.coord.lon);
                rslt.Description = weatherInfo.weather[0].description;
                rslt.Humidity = Convert.ToString(weatherInfo.main.humidity);
                rslt.Temp = Convert.ToString(weatherInfo.main.temp);
                rslt.TempFeelsLike = Convert.ToString(weatherInfo.main.feels_like);
                rslt.TempMax = Convert.ToString(weatherInfo.main.temp_max);
                rslt.TempMin = Convert.ToString(weatherInfo.main.temp_min);
                rslt.WeatherIcon = Convert.ToString(weatherInfo.weather[0].icon);

                //Converting OBJECT to JSON String   
                var jsonstring = new JavaScriptSerializer().Serialize(rslt);

                //Return JSON string.  
                return rslt;

            }
        }
    }
}
