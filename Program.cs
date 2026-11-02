using System.Management;

var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");

foreach (ManagementObject item in searcher.Get())
{
    Console.WriteLine($"Название: {item["Name"]}");
    Console.WriteLine($"Ядер: {item["NumberOfCores"]}");
    Console.WriteLine($"Логических процессоров: {item["NumberOfLogicalProcessors"]}");
}
