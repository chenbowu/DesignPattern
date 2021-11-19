using DesignPattern.Builder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    internal class ApplePhone : IPhone
    {
        public IMainboard Mainboard { get; set; }
        public ICPU CPU { get; set; }
        public IMemory Memory { get; set; }
        public IScreen Screen { get; set; }

        public void Show()
        {
            Console.WriteLine($"Mainboard:{ Mainboard.Type }");
            Console.WriteLine($"CPU:{ CPU.Type }");
            Console.WriteLine($"Memory:{ Memory.Type }");
            Console.WriteLine($"Screen:{ Screen.Type }");
        }
    }
}
