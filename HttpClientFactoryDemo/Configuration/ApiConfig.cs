using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Configuration
{
    public class ApiConfig : IApiConfig
    {
        public string BaseURL { get; set; }
    }
}
