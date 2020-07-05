using System;
using System.Collections.Generic;

namespace BlazorCountryInfo
{
  public static class Constants
  {
    public static Dictionary<string, string> FIELDS = new Dictionary<string, string>
    {
      { "topLevelDomain", "Domain" },
      { "callingCodes", "Call Code" },
      { "capital", "Capital" },
      { "population", "Population" },
      { "timezones", "Time Zone" },
      { "currencies", "Currency" },
      { "subregion", "Continent" },
      { "nativeName", "Native Name" }
    };
  }

  public static class ApiFieldNames
  {
    public static string Domain { get { return "topLevelDomain"; } }
    public static string CallingCode { get { return "callingCodes"; } }
    public static string Capital { get { return "capital"; } }
    public static string Population { get { return "population"; } }
    public static string TimeZones { get { return "timezones"; } }
    public static string Currencies { get { return "currencies"; } }
    public static string Region { get { return "subregion"; } }
    public static string NativeName { get { return "nativeName"; } }
  }

  // "name": "Colombia",
  //"topLevelDomain": [".co"],
  //"alpha2Code": "CO",
  //"alpha3Code": "COL",
  //"callingCodes": ["57"],
  //"capital": "Bogotá",
  //"altSpellings": ["CO", "Republic of Colombia", "República de Colombia"],
  //"region": "Americas",
  //"subregion": "South America",
  //"population": 48759958,
  //"latlng": [4.0, -72.0],
  //"demonym": "Colombian",
  //"area": 1141748.0,
  //"gini": 55.9,
  //"timezones": ["UTC-05:00"],
  //"borders": ["BRA", "ECU", "PAN", "PER", "VEN"],
  //"nativeName": "Colombia",
  //"numericCode": "170",
  //"currencies": [{
  //    "code": "COP",
  //    "name": "Colombian peso",
  //    "symbol": "$"
  //}],
  //"languages": [{
  //    "iso639_1": "es",
  //    "iso639_2": "spa",
  //    "name": "Spanish",
  //    "nativeName": "Español"
  //}],
  //"translations": {
  //    "de": "Kolumbien",
  //    "es": "Colombia",
  //    "fr": "Colombie",
  //    "ja": "コロンビア",
  //    "it": "Colombia",
  //    "br": "Colômbia",
  //    "pt": "Colômbia"
  //},
  //"flag": "https://restcountries.eu/data/col.svg",
  //"regionalBlocs": [{
  //    "acronym": "PA",
  //    "name": "Pacific Alliance",
  //    "otherAcronyms": [],
  //    "otherNames": ["Alianza del Pacífico"]
  //}, {
  //    "acronym": "USAN",
  //    "name": "Union of South American Nations",
  //    "otherAcronyms": ["UNASUR", "UNASUL", "UZAN"],
  //    "otherNames": ["Unión de Naciones Suramericanas", "União de Nações Sul-Americanas", "Unie van Zuid-Amerikaanse Naties", "South American Union"]
  //}],
  //"cioc": "COL"

}

