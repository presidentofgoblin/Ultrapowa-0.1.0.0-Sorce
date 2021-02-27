namespace Ultrapowa_Clash_Server.World
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;

    internal class Clan
    {
        public Clan()
        {
            this.ChatHistory = new ConcurrentQueue<ClanChatMessage>();
        }

        public Clan(ah ccc)
        {
            this.ClanName = ccc.f2();
            this.ClanMessage = ccc.f4();
            this.Shield = ccc.f6();
            this.ClanStatus = ccc.f0();
            this.RequiredTrophies = ccc.f1();
            this.ChatHistory = new ConcurrentQueue<ClanChatMessage>();
        }

        public Clan(uint clanId)
        {
            this.ClanId = clanId;
            this.ClanName = "Top Clan";
            this.ClanMessage = "Top Clan Message";
            this.Shield = 0xc65d59;
            this.ClanStatus = 1;
            this.RequiredTrophies = 0x3e8;
            this.ChatHistory = new ConcurrentQueue<ClanChatMessage>();
        }

        [JsonIgnore]
        public ConcurrentQueue<ClanChatMessage> ChatHistory { get; set; }

        [EditorBrowsable(1), JsonProperty]
        public List<ClanChatMessage> ChatHistoryInternalList
        {
            get
            {
                if (!this.ChatHistory.Any<ClanChatMessage>())
                {
                    return null;
                }
                return this.ChatHistory.ToList<ClanChatMessage>();
            }
            set
            {
                if (value != null)
                {
                    foreach (ClanChatMessage message in value)
                    {
                        this.ChatHistory.Enqueue(message);
                    }
                }
            }
        }

        public uint ClanId { get; set; }

        public string ClanMessage { get; set; }

        public string ClanName { get; set; }

        public uint ClanStatus { get; set; }

        public uint RequiredTrophies { get; set; }

        public uint Shield { get; set; }
    }
}

