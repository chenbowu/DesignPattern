using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.Interface
{
    internal interface IPhoneBuilder
    {
        IPhoneBuilder UseCpu();
        IPhoneBuilder UseMainboard();
        IPhoneBuilder UseMemory();
        IPhoneBuilder UseScreen();
        IPhone Builder();
    }
}
