namespace API;

public class WeatherForecast
{
  public DateTime Date { get; set; }

  public int TemperatureC { get; set; }

  public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

  public string Summary { get; set; }
}

// Nullabe reference type- like optional prop. Can be set to null and there won't be any compliants 
// Downside is a noreference exception without any errors until runtime
// to address that complication is the nullable tag in API.csproj
//   public string? Summary { get; set; }
