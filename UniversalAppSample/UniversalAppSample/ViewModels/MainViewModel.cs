using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversalAppSample.Services;

namespace UniversalAppSample.ViewModels
{
    public class MainViewModel
    {
        private readonly ISampleService _sampleService;
        public MainViewModel(ISampleService sampleService)
        {
            _sampleService = sampleService;
            Welcome = _sampleService.GetWelcomeMessage();
        }

        public string Welcome { get;  }
    }
}
