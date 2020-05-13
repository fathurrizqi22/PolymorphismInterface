using System;
using System.Collections.Generic;
using System.Text;

namespace TugasPolymorphism2
{
    interface IPrinterWindows
    {
        void show();
        void Print();
    }

    public class PrinterWindows : IPrinterWindows
    {
        public void show()
        {
            Console.WriteLine("printer windows dimension: ");
        }

        public void Print()
        {
            Console.WriteLine("printer windows printing...");
        }
    }

    public class Epson : IPrinterWindows
    {
        public void show()
        {
            Console.WriteLine("Printer Epson dimension: 10 * 11");
        }

        public void Print()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }

    public class Canon : IPrinterWindows
    {
        public void show()
        {
            Console.WriteLine("Printer Canon dimension: 9.5 * 12");
        }

        public void Print()
        {
            Console.WriteLine("Canon printer printing....");
        }

    }

    public class Laserjet : IPrinterWindows
    {
        public void show()
        {
            Console.WriteLine("Printer Laser Jet dimension 12 * 12");
        }

        public void Print()
        {
            Console.WriteLine("Laser Jet printer printing....");
        }
    }

    
}
