using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridgelr.Shared
{
    public class Idea
    {
        public int index { get; set; } //use int instead of guid because of openai
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
