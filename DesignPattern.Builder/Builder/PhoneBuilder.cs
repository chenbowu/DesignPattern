using DesignPattern.Builder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.Builder
{
    internal class PhoneBuilder : IPhoneBuilder
    {
        private IPhone _phone;
        private ICPU _cpu;
        private IMainboard _mainboard;
        private IMemory _memory;
        private IScreen _screen;

        public IPhone Builder()
        {
            _phone = new ApplePhone();
            _phone.Mainboard = _mainboard;
            _phone.CPU = _cpu;
            _phone.Memory = _memory;
            _phone.Screen = _screen;
            return _phone;
        }

        public IPhoneBuilder SetCPU(ICPU cpu)
        {
            _cpu = cpu;
            return this;
        }

        public IPhoneBuilder SetMainboard(IMainboard mainboard)
        {
            _mainboard = mainboard;
            return this;
        }

        public IPhoneBuilder SetMemory(IMemory memory)
        {
            _memory = memory;
            return this;
        }

        public IPhoneBuilder SetScreen(IScreen screen)
        {
            _screen = screen;
            return this;
        }
    }
}
