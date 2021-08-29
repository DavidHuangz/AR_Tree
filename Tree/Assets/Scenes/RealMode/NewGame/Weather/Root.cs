using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Newtonsoft.Json;

    [Serializable]
    public class Coord
    {
        public double lon;
        public double lat;
    }

    [Serializable]
    public class Weather
    {
        public int id;
        public string main;
        public string description;
        public string icon;
    }

    [Serializable]
    public class Main
    {
        public double temp;
        public double feels_like;
        public double temp_min;
        public double temp_max;
        public int pressure;
        public int humidity;
        public int sea_level;
        public int grnd_level;
    }

    [Serializable]
    public class Wind
    {
        public double speed;
        public int deg;
        public double gust;
    }

    [Serializable]
    public class Rain
    {
        [JsonProperty(PropertyName = ("1h"))]
        public double oneh;
        [JsonProperty(PropertyName = ("3h"))]
        public double threeh;
        // public double _1h;
        // public double _3h;
    }

    [Serializable]
    public class Clouds
    {
        public int all;
    }

    [Serializable]
    public class Sys
    {
        public int type;
        public int id;
        public string country;
        public int sunrise;
        public int sunset;
    }

    [Serializable]
    public class Root
    {
        public Coord coord;
        public List<Weather> weather;
        public string @base;
        public Main main;
        public int visibility;
        public Wind wind;
        public Rain rain;
        public Clouds clouds;
        public int dt;
        public Sys sys;
        public int timezone;
        public int id;
        public string name;
        public int cod;
    }
