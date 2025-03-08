using FirmwareGen.Extensions;
using FirmwareGen.VirtualDisks;
using System;
using System.Diagnostics;
using System.IO;

namespace FirmwareGen
{
    public static class VolumeUtils
    {
        public static void UnmountSystemPartition(string DiskId, string SystemPartition)
        {
            Logging.Log("Unmounting SYSTEM");
            RunProgram("powershell.exe", $@"-command ""Get-Partition -DiskNumber {DiskId} | Where {{$_.Type -eq 'System'}} | Remove-PartitionAccessPath -accesspath '{SystemPartition}'""");
        }

        public static void MountSystemPartition(string DiskId, string SystemPartition)
        {
            Logging.Log("Mounting SYSTEM");
            RunProgram("powershell.exe", $@"-command ""Get-Partition -DiskNumber {DiskId} | Where {{$_.Type -eq 'System'}} | Set-Partition -NewDriveLetter '{SystemPartition}'.Substring(0,1)""");
        }

        public static void RunProgram(string Program, string Arguments)
        {
            Process proc = new()
            {
                StartInfo = new ProcessStartInfo(Program, Arguments)
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = false
                }
            };
            _ = proc.Start();
            proc.WaitForExit();
        }

        public static void CopyFile(string Source, string Dest)
        {
            FileInfo _source = new(Source);
            FileInfo _destination = new(Dest);

            DateTime startTime = DateTime.Now;
            _source.CopyTo(_destination, x => Logging.ShowProgress(100, startTime, (ulong)x, (ulong)x, false));
            Logging.Log("");
        }

        public static string MountVirtualHardDisk(string VHDPath, bool readOnly)
        {
            Logging.Log($"Mounting {VHDPath}{(readOnly ? " as read only" : "")}...");
            string id = VHDUtils.MountVHD(VHDPath, readOnly);
            Logging.Log($@"Mounted VHD at \\.\PhysicalDisk{id}", Logging.LoggingLevel.Warning);
            return id;
        }

        public static void DismountVirtualHardDisk(string VHDPath)
        {
            Logging.Log($"Dismounting {VHDPath}...");
            VHDUtils.UnmountVHD(VHDPath);
        }

        public static string GetVirtualHardDiskLetterFromDiskID(string DiskId)
        {
            string TVHDLetter = null;
            Process proc = new()
            {
                StartInfo = new ProcessStartInfo("powershell.exe", $@"-command ""(Get-Partition -DiskNumber {DiskId} | Where {{$_.DriveLetter}}).DriveLetter""")
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            _ = proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();
                Logging.Log($"VHD mounted at: {line}");
                TVHDLetter = $"{line}:";
            }
            proc.WaitForExit();
            return TVHDLetter;
        }
    }
}
