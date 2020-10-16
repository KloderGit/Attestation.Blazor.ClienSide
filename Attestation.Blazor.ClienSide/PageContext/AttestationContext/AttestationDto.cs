using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Attestation.BlazorClienSide.PageContext.AttestationContext
{
    public class AttestationDto
    {
        public Guid Key { get; set; }
        public string Title { get; set; }
        public ControlType Control { get; set; }
        public IEnumerable<KeyTitle> Programs { get; set; }
    }

    public class KeyTitle
    {
        public Guid Key { get; set; }
        public string Title { get; set; }
    }   

    public class ControlType
        {
            public Guid Key { get; set; }
            public string Title { get; set; }
            public string @Type { get; set; }
    }

}
