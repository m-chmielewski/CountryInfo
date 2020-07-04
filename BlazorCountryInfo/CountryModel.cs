using System;
using System.Collections.Generic;

namespace BlazorCountryInfo
{
  public class CountryModel
  {
    public string Name { get; set; }
    public List<Dictionary<string, string>> Currencies { get; set; }
    public decimal Population { get; set; }
    public string Alpha2Code { get; set; }
    public string Flag
    {
      get
      {
        return $"https://www.countryflags.io/{ Alpha2Code }/flat/64.png";
      }
    }
  }
}
