using System;
using System.Collections.Generic;

namespace BlazorCountryInfo
{
  public class PresentationClient
  {
    public Dictionary<string, bool> FieldsToPresent = new Dictionary<string, bool>
    {
      { ApiFieldNames.Currencies, false },
      { ApiFieldNames.Population, true },
      { ApiFieldNames.Domain, false },
      { ApiFieldNames.CallingCode, false },
      { ApiFieldNames.Capital, true },
      { ApiFieldNames.TimeZones, false },
      { ApiFieldNames.Region, false },
      { ApiFieldNames.NativeName, false }
  };

    public string GetDisplayParameter(bool isVisible)
    {
      if (isVisible)
        return "block";

      return "none";
    }
  }
}
