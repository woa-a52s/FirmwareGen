﻿using System;
using FirmwareGen.CommandLine;

namespace FirmwareGen
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Logging.Log("FirmwareGen");
            Logging.Log("Copyright (c) 2019-2024, Gustave Monce - gus33000.me - @gus33000");
            Logging.Log("Released under the MIT license at github.com/WOA-Project/FirmwareGen");
            Logging.Log("");

            try
            {
                CLIOptions.ParseOptionsAndTakeAction(args);
            }
            catch (Exception ex)
            {
                Logging.Log("Something happened.", Logging.LoggingLevel.Error);
                Logging.Log(ex.Message, Logging.LoggingLevel.Error);
                Logging.Log(ex.StackTrace, Logging.LoggingLevel.Error);
                Environment.Exit(1);
            }
        }
    }
}