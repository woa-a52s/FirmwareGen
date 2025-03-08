using FirmwareGen.CommandLine;
using System.IO;

namespace FirmwareGen
{
    public static class MainLogic
    {
        public static bool VerifyAllComponentsArePresent()
        {
            return true;
        }

        public static void GenerateWindowsFFU(GenerateWindowsFFUOptions options)
        {
            const string Img2Ffu = "Img2Ffu.exe";

            DeviceProfile deviceProfile = XmlUtils.Deserialize<DeviceProfile>(options.DeviceProfile);

            string TmpVHD = CommonLogic.GetBlankVHD(deviceProfile);
            //Logging.Log("Making FFU");
            //VolumeUtils.RunProgram(Img2Ffu, $@"-i {TmpVHD} -d VenHw(860845C1-BE09-4355-8BC1-30D64FF8E63A) -l false -b 4000 -e .\provisioning-partitions.txt -i .\LUN1.vhdx -d VenHw(8D90D477-39A3-4A38-AB9E-586FF69ED051) -l true -b 4000 -e .\provisioning-partitions.txt -i .\LUN2.vhdx -d VenHw(EDF85868-87EC-4F77-9CDA-5F10DF2FE601) -l true -b 4000 -e .\provisioning-partitions.txt -i .\LUN3.vhdx -d VenHw(1AE69024-8AEB-4DF8-BC98-0032DBDF5024) -l true -b 4000 -e .\provisioning-partitions.txt -i .\LUN4.vhdx -d VenHw(D33F1985-F107-4A85-BE38-68DC7AD32CEA) -l true -b 4000 -e .\provisioning-partitions.txt -i .\LUN5.vhdx -d VenHw(4BA1D05F-088E-483F-A97E-B19B9CCF59B0) -l true -b 4000 -e .\provisioning-partitions.txt -v V2 -f ""Output\{deviceProfile.FFUFileName}"" -p ""{string.Join(";", deviceProfile.PlatformIDs)}"" -c 16384 -s 4096 ");

            //string DiskId = VolumeUtils.MountVirtualHardDisk(TmpVHD, false);
            //string VHDLetter = VolumeUtils.GetVirtualHardDiskLetterFromDiskID(DiskId);
        }
    }
}
