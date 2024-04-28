using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

public class Color
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("hex")]
    public string Hex { get; set; }
}

public class AttendeesCountries
{
    public int count { get; set; }
    public Dictionary<string, int> countries { get; set; }
}

public class Speaker
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("link")]
    public string Link { get; set; }

    [JsonProperty("avatar")]
    public string Avatar { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }
}

public class Mc : Speaker
{
    [JsonProperty("day")]
    public List<int> Day { get; set; }
}

public class Talk
{
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("slides")]
    public object Slides { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("video")]
    public object Video { get; set; }

    [JsonProperty("speaker")]
    public List<Speaker> Speakers { get; set; }
 }

public class Event
{
    [JsonProperty("days")]
    public int Days { get; set; }

    [JsonProperty("date")]
    public List<string> Date { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("link")]
    public string Link { get; set; }

    [JsonProperty("venue")]
    public string Venue { get; set; }

    [JsonProperty("price")]
    public int Price { get; set; }

    [JsonProperty("color")]
    public Color Color { get; set; }

    [JsonProperty("attendees")]
    public AttendeesCountries Attendees { get; set; }

    [JsonProperty("mc")]
    public List<Mc> MC { get; set; }

    [JsonProperty("talks")]
    public List<Talk> Talks { get; set; }

    [JsonProperty("speakers")]
    public List<Speaker> Speakers { get; set; }
}

public class Root
{
    [JsonProperty("2024")]
    public Event Event2024 { get; set; }

    [JsonProperty("2023")]
    public Event Event2023 { get; set; }

    [JsonProperty("2022")]
    public Event Event2022 { get; set; }

    [JsonProperty("2021")]
    public Event Event2021 { get; set; }

    [JsonProperty("2020")]
    public Event Event2020 { get; set; }

    [JsonProperty("2019")]
    public Event Event2019 { get; set; }

    [JsonProperty("2018")]
    public Event Event2018 { get; set; }

    [JsonProperty("2017")]
    public Event Event2017 { get; set; }

    [JsonProperty("2016")]
    public Event Event2016 { get; set; }

    [JsonProperty("2015")]
    public Event Event2015 { get; set; }

    [JsonProperty("2014")]
    public Event Event2014 { get; set; }

    [JsonProperty("2013")]
    public Event Event2013 { get; set; }

    [JsonProperty("2012")]
    public Event Event2012 { get; set; }

    [JsonProperty("2011")]
    public Event Event2011 { get; set; }
}


public class Video
{
    [JsonProperty("youtube-id")]
    public string YoutubeId { get; set; }

    [JsonProperty("youtube-link")]
    public string YoutubeLink { get; set; }

    [JsonProperty("vimeo-id")]
    public string VimeoId { get; set; }

    [JsonProperty("vimeo-link")]
    public string VimeoLink { get; set; }

    [JsonProperty("thumbnail")]
    public string Thumbnail { get; set; }

    [JsonProperty("views")]
    public int Views { get; set; }

    [JsonProperty("likes")]
    public int Likes { get; set; }
}

public enum Year
{
    [Display(Name = "2024")]
    year_2024 = 0,
    [Display(Name = "2023")]
    year_2023 = 1,
    [Display(Name = "2022")]
    year_2022 = 2,
    //[Display(Name = "2021")]
    //year_2021 = 3,
    //[Display(Name = "2020")]
    //year_2020 = 4,
    [Display(Name = "2019")]
    year_2019 = 5,
    [Display(Name = "2018")]
    year_2018 = 6,
    [Display(Name = "2017")]
    year_2017 = 7,
    [Display(Name = "2016")]
    year_2016 = 8,
    [Display(Name = "2015")]
    year_2015 = 9,
    [Display(Name = "2014")]
    year_2014 = 10,
    [Display(Name = "2013")]
    year_2013 = 11,
}