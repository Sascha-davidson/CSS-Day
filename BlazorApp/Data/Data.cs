using Newtonsoft.Json;

public class Color
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("hex")]
    public string Hex { get; set; }
}

public class AttendeesCountries
{
    [JsonProperty("NL")]
    public int Netherlands { get; set; }

    [JsonProperty("DE")]
    public int Germany { get; set; }

    [JsonProperty("FR")]
    public int France { get; set; }

    [JsonProperty("US")]
    public int UnitedStates { get; set; }

    [JsonProperty("UK")]
    public int UnitedKingdom { get; set; }

    [JsonProperty("BE")]
    public int Belgium { get; set; }

    [JsonProperty("NO")]
    public int Norway { get; set; }

    [JsonProperty("CA")]
    public int Canada { get; set; }

    [JsonProperty("SK")]
    public int Slovakia { get; set; }

    [JsonProperty("IL")]
    public int Israel { get; set; }

    [JsonProperty("ES")]
    public int Spain { get; set; }

    [JsonProperty("DK")]
    public int Denmark { get; set; }

    [JsonProperty("SE")]
    public int Sweden { get; set; }

    [JsonProperty("PL")]
    public int Poland { get; set; }

    [JsonProperty("EE")]
    public int Estonia { get; set; }

    [JsonProperty("AT")]
    public int Austria { get; set; }

    [JsonProperty("LB")]
    public int Lebanon { get; set; }
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

public class Talk
{
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("slides")]
    public bool Slides { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("video")]
    public bool Video { get; set; }
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
    public List<Speaker> MC { get; set; }

    [JsonProperty("talks")]
    public List<Talk> Talks { get; set; }

    [JsonProperty("speakers")]
    public List<Speaker> Speakers { get; set; }
}

public class Root
{
    [JsonProperty("2024")]
    public Event Event2024 { get; set; }


}
