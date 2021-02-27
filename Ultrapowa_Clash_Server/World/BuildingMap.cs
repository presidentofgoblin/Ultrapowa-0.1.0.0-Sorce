namespace Ultrapowa_Clash_Server.World
{
    using FileHelpers;
    using System;
    using System.Runtime.CompilerServices;

    [DelimitedRecord(";")]
    internal class BuildingMap
    {
        public int BuildingId { get; set; }

        public int BuildingLevel { get; set; }

        public string ExportName { get; set; }
    }
}

