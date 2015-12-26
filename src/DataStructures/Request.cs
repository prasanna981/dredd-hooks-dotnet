using System.Collections.Generic;

namespace dredd_hooks_dotnet
{
  public struct Request
  {
    string body;
    IDictionary<string, string> headers;
    string uri;
    string method;
  }
}

