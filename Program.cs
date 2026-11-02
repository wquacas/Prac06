using System.Management;

// var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");

// foreach (ManagementObject item in searcher.Get())
// {
//     Console.WriteLine($"Название: {item["Name"]}");
//     Console.WriteLine($"Ядер: {item["NumberOfCores"]}");
//     Console.WriteLine($"Логических процессоров: {item["NumberOfLogicalProcessors"]}");
// }

var osSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

foreach (ManagementObject os in osSearcher.Get()) {
    Console.WriteLine($"ОС: {os["Caption"]}");
    Console.WriteLine($"Версия: {os["Version"]}");
}

