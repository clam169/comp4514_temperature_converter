using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Temperature;

namespace TemperatureClient.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
      this.InputValue = 0;
      this.ConvertedValue = 0;
      this.ConvertFrom = "Fahrenheit0";
      this.ConvertTo = "Fahrenheit0";

  }

    public void OnGet()
    {

    }
    [BindProperty]
    public double InputValue { get; set; }
    [BindProperty]
    public double ConvertedValue { get; set; }
    [BindProperty]
    public string ConvertFrom { get; set; }
    [BindProperty]
    public string ConvertTo { get; set; }

    public void OnPost() {
      Conversion c = new Conversion();
      
      if(ConvertTo.Equals(ConvertFrom)) {
        ConvertedValue = InputValue;
      } else {
        if(ConvertFrom.Equals("Celcius")) {
          if (ConvertTo.Equals("Fahrenheit")) {
            ConvertedValue = c.Convert(Conversion.ConversionMode.Celsius_to_Fahrenheit, InputValue);
          } else {
            ConvertedValue = c.Convert(Conversion.ConversionMode.Celsius_to_Kelvin, InputValue);
          }
        } else if (ConvertFrom.Equals("Fahrenheit")) {
          if (ConvertTo.Equals("Celcius")) {
            ConvertedValue = c.Convert(Conversion.ConversionMode.Fahrenheit_to_Celsius, InputValue);
          } else {
            ConvertedValue = c.Convert(Conversion.ConversionMode.Fahrenheit_to_Kelvin, InputValue);
          }
        } else if (ConvertFrom.Equals("Kelvin")) {
          if (ConvertTo.Equals("Celcius")) {
            ConvertedValue = c.Convert(Conversion.ConversionMode.Kelvin_to_Celsius, InputValue);
          } else {
            ConvertedValue = c.Convert(Conversion.ConversionMode.Kelvin_to_Fahrenheit, InputValue);
          }
        }
      }
    }
}
