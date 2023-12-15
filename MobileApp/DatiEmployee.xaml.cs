using MobileApp.Models;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MobileApp;

public partial class DatiEmployee : ContentPage
{
	public DatiEmployee()
	{
		InitializeComponent();
	}

    private async void RequestEmployee_Clicked(object sender, EventArgs e)
    {
		HttpClient _httpClient = new ();

		HttpResponseMessage _httpResponseMessage = await _httpClient.GetAsync("https://localhost:7145/api/AnagraficaGenerales");
		if (_httpResponseMessage.IsSuccessStatusCode)
		{
			var obj = _httpResponseMessage.Content.ReadAsStringAsync().Result;
			var data = JsonConvert.DeserializeObject<List<Employee>>(obj);
			foreach (var item in data)
			{
				Console.WriteLine(item);
			}

		}
    }
}