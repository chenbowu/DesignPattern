using DesignPattern.Builder.Builder;
using DesignPattern.Builder.Interface;
using DesignPattern.Builder.PhoneParts;
using System;

namespace DesignPattern.Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IPhone phone = new PhoneBuilder()
                .SetScreen(new SamsungScreen())
                .SetCPU(new IntelCPU())
                .SetMemory(new SamsungMemory())
                .SetMainboard(new GigaMainboard())
                .Builder();
            phone.Show();
        }
        // 委托的形参的是调用方传递的对象引用，在委托内为此对象重新赋值时，不会对原对象造成修改。
        // 相当于只修改了形参变量的引用地址。
        static void SetCpu(Action<ICPU> action)
        {
            ICPU cpu = new IntelCPU();
            action.Invoke(cpu);
            Console.WriteLine(cpu.Type);
        }
    }
}
