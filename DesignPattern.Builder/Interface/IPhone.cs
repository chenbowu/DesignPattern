using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.Interface
{
    internal interface IPhone
    {
        IMainboard Mainboard { get; set; }
        ICpu Cpu { get; set; }
        IMemory Memory { get; set; }
        IScreen Screen { get; set; }
        void Show();
    }
}
