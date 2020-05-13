using System;

namespace TugasPolymorphism2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih printer: \n1. Epson\n2. Canon\n3. LaserJet");

            Console.Write("\nNomor Printer [1 ... 3] : ");
            int pilihPrinter = Convert.ToInt32(Console.ReadLine());

            IPrinterWindows printer = new PrinterWindows();


            if (pilihPrinter == 1)
            {
                printer = new Epson();
            }
            else if (pilihPrinter == 2)
            {
                printer = new Canon();
            }
            else
            {
                printer = new Laserjet();
            }

            printer.show();
            printer.Print();
        }
    }
}
