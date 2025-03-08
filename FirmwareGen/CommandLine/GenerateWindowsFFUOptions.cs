using CommandLine;

namespace FirmwareGen.CommandLine
{
    [Verb("generate-windows-ffu", HelpText = "Generates a ffu from a Windows Base VHDX")]
    public class GenerateWindowsFFUOptions
    {
        [Option('p', "device-profile", HelpText = "Path to the device profile xml containing information on how to build the FFU", Required = true)]
        public string DeviceProfile
        {
            get; set;
        }
    }
}
