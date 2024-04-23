using Newtonsoft.Json;

namespace BlazorApp.Components.Pages
{
    public partial class Home
    {
        protected Root? root { get; set; }

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
    }
}
