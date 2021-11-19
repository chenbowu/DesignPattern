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
        public IMainboard Mainboard { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICpu Cpu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IMemory Memory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IScreen Screen { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }
}
