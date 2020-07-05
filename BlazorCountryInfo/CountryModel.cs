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
    public List<string> TopLevelDomain { get; set; }
    public List<string> CallingCodes { get; set; }
    public string Capital { get; set; }
    public List<string> TimeZones { get; set; }
    public string Subregion { get; set; }
    public string NativeName { get; set; }

    public string FormattedPopulation
    {
      get
      {
        if (Population > 1000000000) //Billion
          return $"{ Population / 1000000000:F3} B";

        if (Population > 1000000) //Milion
          return $"{ Population / 1000000:F3} M";

        return $"{ Population / 1000 } k";
      }
    }

    public string Flag
    {
      get
      {
        return $"https://www.countryflags.io/{ Alpha2Code }/flat/64.png";
      }
    }
  }
}
