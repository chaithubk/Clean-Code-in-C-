using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10_AddressingCrossCuttingConcerns.ProxyPattern
{
    public class Proxy : IService
    {
        private IService _service;

        public Proxy(IService service)
        {
            _service = service;
        }

        public void Request()
        {
            Console.WriteLine("Proxy: Request();");
            _service.Request();
        }
    }
}
