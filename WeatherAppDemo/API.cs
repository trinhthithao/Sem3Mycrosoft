﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace WeatherAppDemo
{
   public class API
    {
        public async static Task<RootObject> GetWeather(double lat, double lon)
        {
            var http = new HttpClient();
            var url = String.Format("http://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&units=metric&appid=4450624a61b690262043494c00962a9b", lat, lon);
            var response = await http.GetAsync(url);//nhan data json tu weathermap.org
            var result = await response.Content.ReadAsStringAsync();

            var serializer = new DataContractJsonSerializer(typeof(RootObject));
            //khoi tao stream local de doc json 
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            //doc object da nhan tu json vaof stream local de phan tich 
            var data = (RootObject)serializer.ReadObject(ms);
            return data;
        }
    }
    public class Main
    {
        public double temp { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public double pressure { get; set; }
        public double sea_level { get; set; }
        public double grnd_level { get; set; }
        public int humidity { get; set; }
        public double temp_kf { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
        public double deg { get; set; }
    }

    public class Rain
    {
        public double? __invalid_name__3h { get; set; }
    }

    public class Sys
    {
        public string pod { get; set; }
    }

    public class List
    {
        public int dt { get; set; }
        public Main main { get; set; }
        public List<Weather> weather { get; set; }
        public Clouds clouds { get; set; }
        public Wind wind { get; set; }
        public Rain rain { get; set; }
        public Sys sys { get; set; }
        public string dt_txt { get; set; }
    }

    public class Coord
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public Coord coord { get; set; }
        public string country { get; set; }
        public int population { get; set; }
    }

    public class RootObject
    {
        public string cod { get; set; }
        public double message { get; set; }
        public int cnt { get; set; }
        public List<List> list { get; set; }
        public City city { get; set; }
    }


}