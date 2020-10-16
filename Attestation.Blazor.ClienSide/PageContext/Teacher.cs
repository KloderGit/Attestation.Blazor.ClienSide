using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Attestation.BlazorClienSide.PageContext
{
    public class Teacher
    {
        public Guid Key { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
    }
}
