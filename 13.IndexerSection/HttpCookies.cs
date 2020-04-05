using System;
using System.Collections.Generic;

namespace IndexerSection {

  public class HttpCookies {

    private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
    public DateTime Expiry { get; set; }

    public string this[string key] {
      get { return _dictionary[key]; }
      set { _dictionary[key] = value; }
    }

  }
}