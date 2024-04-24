using Newtonsoft.Json;

namespace BlazorApp.Components.Pages
{
    public partial class Home
    {
        protected Root? root { get; set; }
        protected Year SelectedYear = Year.year_2024;
        protected bool IsShowingDropDown = false;

        protected Event? CurrentData => SelectedYear switch
        {
            Year.year_2024 => root?.Event2024,
            Year.year_2023 => root?.Event2023,
            Year.year_2022 => root?.Event2022,
            Year.year_2021 => root?.Event2021,
            Year.year_2020 => root?.Event2020,
            Year.year_2019 => root?.Event2019,
            Year.year_2018 => root?.Event2018,
            Year.year_2017 => root?.Event2017,
            Year.year_2016 => root?.Event2016,
            Year.year_2015 => root?.Event2015,
            Year.year_2014 => root?.Event2014,
            Year.year_2013 => root?.Event2013,
            _ => root?.Event2024 // Default case if SelectedYear doesn't match any specific case
        };



        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://cssday.nl/data.json");

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
            root = JsonConvert.DeserializeObject<Root>(result);
        }

        public void SetYear(Year year)
        {
            SelectedYear = year;
            IsShowingDropDown = false;
            StateHasChanged();
        }

        public void ToggleDropDown()
        {
            IsShowingDropDown = !IsShowingDropDown;
            StateHasChanged();
        }

        private Video? GetVideoDate(object data)
        {
           var serialized =  JsonConvert.SerializeObject(data);
            return JsonConvert.DeserializeObject<Video>(serialized);
        }
    }
}
