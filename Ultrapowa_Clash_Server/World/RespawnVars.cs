namespace Ultrapowa_Clash_Server.World
{
    using System;
    using System.Runtime.CompilerServices;

    internal class RespawnVars
    {
        public uint obstacleClearCounter { get; set; }

        public uint respawnSeed { get; set; }

        public uint secondsFromLastRespawn { get; set; }

        public uint time_in_gembox_period { get; set; }

        public uint time_to_gembox_drop { get; set; }
    }
}

