using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.Interface
{
    internal interface IPhoneBuilder
    {
        IPhoneBuilder SetCPU(ICPU cpu);
        IPhoneBuilder SetMainboard(IMainboard mainboard);
        IPhoneBuilder SetMemory(IMemory memory);
        IPhoneBuilder SetScreen(IScreen screen);
        IPhone Builder();
    }
}
