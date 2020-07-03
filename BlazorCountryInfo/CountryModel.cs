using System;
using System.Collections.Generic;

namespace BlazorCountryInfo
{
  public class CountryModel
  {
    public string Name { get; set; }
    public List<Dictionary<string, string>> Currencies { get; set; }
    public decimal Population { get; set; }
  }
}
