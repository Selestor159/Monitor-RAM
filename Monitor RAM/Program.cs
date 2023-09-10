using System;
using System.Management;

class RAMInfo
{
    static void Main()
    {
        ManagementObjectSearcher searcher =
            new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");

        Console.WriteLine("RAM Information:");

        foreach (ManagementObject obj in searcher.Get())
        {
            Console.WriteLine("Capacity: {0} GB", Math.Round(Convert.ToDouble(obj["Capacity"]) / (1024 * 1024 * 1024), 2));
            Console.WriteLine("Manufacturer: {0}", obj["Manufacturer"]);
            Console.WriteLine("Speed: {0} MHz", obj["Speed"]);
            Console.WriteLine("Part Number: {0}", obj["PartNumber"]);
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
