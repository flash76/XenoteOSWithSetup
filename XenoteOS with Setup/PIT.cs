

using System;
using Extensions;
namespace Core
{
    public static class PIT
    {
        public static void Mode0(uint frequency)
        {
            Core.IDT.Remap();
            uint divisor = 1193182 / frequency;
            IO.PortIO.outb(0x43, 0x30);
            IO.PortIO.outb(0x40, (byte)(divisor & 0xFF));
            IO.PortIO.outb(0x40, (byte)((divisor >> 8) & 0xFF));
            Core.IRQ.ClearMask(0);
            Core.IRQ.ClearMask(15);
        }
        public static void Mode2(uint frequency)
        {
            Core.IDT.Remap();
            uint divisor = 1193182 / frequency;
            IO.PortIO.outb(0x43, 0x36);
            IO.PortIO.outb(0x40, (byte)(divisor & 0xFF));
            IO.PortIO.outb(0x40, (byte)((divisor >> 8) & 0xFF));
            Core.IRQ.ClearMask(0);
            Core.IRQ.ClearMask(15);
        }
        public static void Beep(uint frequency)
        {
            uint divisor = 1193182 / frequency;
            IO.PortIO.outb(0x43, 0xB6);
            IO.PortIO.outb(0x42, (byte)(divisor & 0xFF));
            IO.PortIO.outb(0x42, (byte)((divisor >> 8) & 0xFF));
        }
        internal static bool called = false;
        public static void SleepSeconds(uint seconds)
        {
            SleepMilliseconds(seconds * 1000);
        }
        public static void SleepMilliseconds(uint milliseconds)
        {
            if (milliseconds <= 50)
            {
                called = false;
                Mode0(milliseconds.MsToHz());
                while (!called) { }
                called = false;
            }
            else
            {
                uint mod = milliseconds % 100;
                uint ms = milliseconds - mod;
                for (int i = 0; i < ms; i += 50)
                {
                    called = false;
                    Mode0(20);
                    while (!called) { }
                }
                called = false;
                ms = mod % 2;
                for (int i = 0; i < ms; i += 2)
                {
                    called = false;
                    Mode0(500);
                    while (!called) { }
                }
                called = false;
            }
        }
    }
}
