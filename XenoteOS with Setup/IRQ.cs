
using System;
using System.Collections.Generic;

namespace de.Core
{
    public class IRQ
    {
        public static void SetMask(byte IRQline)
        {
            ushort port;
            byte value;

            if (IRQline < 8)
            {
                port = 0x20 + 1;
            }
            else
            {
                port = 0xA0 + 1;
                IRQline -= 8;
            }
            value = (byte)(IO.PortIO.inb(port) | (1 << IRQline));
            IO.PortIO.outb(port, value);
        }
        public static void ClearMask(byte IRQline)
        {
            ushort port;
            byte value;

            if (IRQline < 8)
            {
                port = 0x20 + 1;
            }
            else
            {
                port = 0xA0 + 1;
                IRQline -= 8;
            }
            value = (byte)(IO.PortIO.inb(port) & ~(1 << IRQline));
            IO.PortIO.outb(port, value);
        }
    }
}
