﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AntDesign.Charts.Docs.Demos
{
    public static class DemoData
    {
        public static async Task<FireworksSalesItem[]> FireworksSalesAsync(NavigationManager NavigationManager, HttpClient HttpClient)
        {
            var baseUrl = NavigationManager.ToAbsoluteUri(NavigationManager.BaseUri);
            return await HttpClient.GetFromJsonAsync<FireworksSalesItem[]>(new Uri(baseUrl, "_content/AntDesign.Charts.Docs/data/fireworks-sales.json").ToString());
        }

        public static async Task<SalesItem[]> SalesAsync(NavigationManager NavigationManager, HttpClient HttpClient)
        {
            var baseUrl = NavigationManager.ToAbsoluteUri(NavigationManager.BaseUri);
            return await HttpClient.GetFromJsonAsync<SalesItem[]>(new Uri(baseUrl, "_content/AntDesign.Charts.Docs/data/sales.json").ToString());
        }

        public static async Task<GDPItem[]> GDPAsync(NavigationManager NavigationManager, HttpClient HttpClient)
        {
            var baseUrl = NavigationManager.ToAbsoluteUri(NavigationManager.BaseUri);
            return await HttpClient.GetFromJsonAsync<GDPItem[]>(new Uri(baseUrl, "_content/AntDesign.Charts.Docs/data/GDP.json").ToString());
        }

        public static async Task<GDPItem[]> EmissionsAsync(NavigationManager NavigationManager, HttpClient HttpClient)
        {
            var baseUrl = NavigationManager.ToAbsoluteUri(NavigationManager.BaseUri);
            return await HttpClient.GetFromJsonAsync<GDPItem[]>(new Uri(baseUrl, "_content/AntDesign.Charts.Docs/data/emissions.json").ToString());
        }

        public static async Task<OilItem[]> OilAsync(NavigationManager NavigationManager, HttpClient HttpClient)
        {
            var baseUrl = NavigationManager.ToAbsoluteUri(NavigationManager.BaseUri);
            return await HttpClient.GetFromJsonAsync<OilItem[]>(new Uri(baseUrl, "_content/AntDesign.Charts.Docs/data/oil.json").ToString());
        }

        public static async Task<IMDBItem[]> IMDBAsync(NavigationManager NavigationManager, HttpClient HttpClient)
        {
            var baseUrl = NavigationManager.ToAbsoluteUri(NavigationManager.BaseUri);
            return await HttpClient.GetFromJsonAsync<IMDBItem[]>(new Uri(baseUrl, "_content/AntDesign.Charts.Docs/data/IMDB.json").ToString());
        }

        public static async Task<SmokingRateItem[]> SmokingRateAsync(NavigationManager NavigationManager, HttpClient HttpClient)
        {
            var baseUrl = NavigationManager.ToAbsoluteUri(NavigationManager.BaseUri);
            return await HttpClient.GetFromJsonAsync<SmokingRateItem[]>(new Uri(baseUrl, "_content/AntDesign.Charts.Docs/data/smoking-rate.json").ToString());
        }

        public static async Task<BasementProdItem[]> BasementProdAsync(NavigationManager NavigationManager, HttpClient HttpClient)
        {
            var baseUrl = NavigationManager.ToAbsoluteUri(NavigationManager.BaseUri);
            return await HttpClient.GetFromJsonAsync<BasementProdItem[]>("https://gw.alipayobjects.com/os/basement_prod/a719cd4e-bd40-4878-a4b4-df8a6b531dfe.json");
        }

        public static async Task<JobpayingItem[]> JobpayingItemAsync(NavigationManager NavigationManager, HttpClient HttpClient)
        {
            var baseUrl = NavigationManager.ToAbsoluteUri(NavigationManager.BaseUri);
            return await HttpClient.GetFromJsonAsync<JobpayingItem[]>(new Uri(baseUrl, "_content/AntDesign.Charts.Docs/data/jobpaying.json").ToString());
        }
    }

    public class FireworksSalesItem
    {
        [JsonPropertyName("Date")]
        public string Date { get; set; }
        public int scales { get; set; }
    }

    public class SalesItem
    {

        public string 城市 { get; set; }
        public decimal 销售额 { get; set; }
    }

    public class GDPItem
    {
        public string name { get; set; }
        public string year { get; set; }
        public decimal gdp { get; set; }
    }

    public class EmissionsItem
    {
        public string year { get; set; }
        public int value { get; set; }
        public string category { get; set; }
    }

    public class OilItem
    {
        public string country { get; set; }
        public int date { get; set; }
        public decimal value { get; set; }
    }

    public class IMDBItem
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public decimal? Revenue { get; set; }
        public decimal? Rating { get; set; }
    }
    public class SmokingRateItem
    {
        public string iso3 { get; set; }
        [JsonPropertyName("change in female rate")]
        public object change_in_female_rate { get; set; }
        [JsonPropertyName("change in male rate")]
        public object change_in_male_rate { get; set; }
        public object female_2000 { get; set; }
        public object male_2000 { get; set; }
        public object female_2015 { get; set; }
        public object male_2015 { get; set; }
        public string income { get; set; }
        public int pop { get; set; }
        public string EN { get; set; }
        public string DE { get; set; }
        public string FR { get; set; }
        public string IT { get; set; }
        public string ES { get; set; }
        public string PT { get; set; }
        public string RU { get; set; }
        public string ZH { get; set; }
        public string JA { get; set; }
        public string AR { get; set; }
        public string continent { get; set; }
    }

    public class BasementProdItem
    {
        [JsonPropertyName("Month of Year")]
        public object MonthofYear { get; set; }
        public object Month_of_Year { get { return MonthofYear; } }
        public object District { get; set; }
        public object AQHI { get; set; }

    }

    public class JobpayingItem
    {
        public object rank { get; set; }
        public object code { get; set; }
        public object prob { get; set; }
        public object average_annual_wage { get; set; }
        public object education { get; set; }
        public object occupation { get; set; }
        public object short_occupation { get; set; }
        public object len { get; set; }
        public object probability { get; set; }
        public object median_ann_wage { get; set; }
        public object employed_may2016 { get; set; }
        public object average_ann_wage { get; set; }
    }
}
