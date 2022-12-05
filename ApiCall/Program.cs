using ConsumeApiDemo.obj;
using System.Text.Json;
using System;

namespace ConsumeApiDemo;
class Program
{
    static async Task Main(string[] args)
    {
        //Response from API, get array of object
        HttpClient client = new HttpClient();
        
        using HttpResponseMessage response = await client.GetAsync("https://secure.runescape.com/m=hiscore/ranking.json?table=9&category=0&size=2");
        string responseBody = await response.Content.ReadAsStringAsnyc();


    }
}
