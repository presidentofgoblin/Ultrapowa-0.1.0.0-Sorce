namespace Ultrapowa_Clash_Server.World
{
    using System;
    using System.Runtime.CompilerServices;

    internal class ClanChatMessage
    {
        public ClanChatMessage()
        {
            this.Unknown1 = 2;
            this.Unknown2 = 0;
            this.ServerTick = 0x975d3a96;
            this.Region1 = 1;
            this.PlayerId1 = 0x1d1dac;
            this.Region2 = 1;
            this.PlayerId2 = 0x1d1dac;
            this.PlayerName = "Ultrapowa";
            this.Unknown3 = 0x53;
            this.Unknown4 = 8;
            this.MemberStatus = 2;
            this.MessageTime = 0;
            this.Unknown5 = 0;
            this.Message = "Welcome to the Ultrapowa Clash Server";
        }

        public ClanChatMessage(y cccm, Player p)
        {
            this.Unknown1 = 2;
            this.Unknown2 = 0;
            this.ServerTick = (uint) DateTime.UtcNow.Subtract(new DateTime(0x7b2, 1, 1)).TotalSeconds;
            this.Region1 = p.Region;
            this.PlayerId1 = p.PlayerId;
            this.Region2 = p.Region;
            this.PlayerId2 = p.PlayerId;
            this.PlayerName = p.PlayerName;
            this.Unknown3 = 0x53;
            this.Unknown4 = 8;
            this.MemberStatus = 2;
            this.MessageTime = (uint) DateTime.UtcNow.Subtract(new DateTime(0x7b2, 1, 1)).TotalSeconds;
            this.Unknown5 = 0;
            this.Message = cccm.f0();
        }

        public uint MemberStatus { get; set; }

        public string Message { get; set; }

        public uint MessageTime { get; set; }

        public uint PlayerId1 { get; set; }

        public uint PlayerId2 { get; set; }

        public string PlayerName { get; set; }

        public uint Region1 { get; set; }

        public uint Region2 { get; set; }

        public uint ServerTick { get; set; }

        public uint TimeFromMessage
        {
            get
            {
                return (((uint) DateTime.UtcNow.Subtract(new DateTime(0x7b2, 1, 1)).TotalSeconds) - this.MessageTime);
            }
        }

        public uint Unknown1 { get; set; }

        public uint Unknown2 { get; set; }

        public uint Unknown3 { get; set; }

        public uint Unknown4 { get; set; }

        public byte Unknown5 { get; set; }
    }
}

