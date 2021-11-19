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
        public IPhone Builder()
        {
            _phone = new ApplePhone();
            throw new NotImplementedException();
        }

        public IPhoneBuilder UseCpu()
        {
            throw new NotImplementedException();
        }

        public IPhoneBuilder UseMainboard()
        {
            throw new NotImplementedException();
        }

        public IPhoneBuilder UseMemory()
        {
            throw new NotImplementedException();
        }

        public IPhoneBuilder UseScreen()
        {
            throw new NotImplementedException();
        }
    }
}
