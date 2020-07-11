using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploDI.Service
{
    public class GuidService
    {
        public readonly Guid ResultadoGuid;

        public GuidService()
        {
            ResultadoGuid = Guid.NewGuid();
        }
    }
}
