namespace Ultrapowa_Clash_Server.World
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    internal class Village
    {
        public Village()
        {
        }

        public Village(uint playerId)
        {
            this.android_client = true;
            List<Item> list = new List<Item>();
            Item item = new Item {
                data = 0xf4241,
                lvl = 1,
                x = 0x15,
                y = 20
            };
            list.Add(item);
            Item item2 = new Item {
                data = 0xf424e,
                lvl = 0,
                locked = false,
                x = 0x19,
                y = 0x20
            };
            list.Add(item2);
            Item item3 = new Item {
                data = 0xf424f,
                lvl = 0,
                x = 0x15,
                y = 0x18
            };
            list.Add(item3);
            this.buildings = list;
            this.obstacles = new Item[0];
            this.traps = new Item[0];
            this.decos = new Item[0];
            RespawnVars vars = new RespawnVars {
                secondsFromLastRespawn = 0x218,
                respawnSeed = 0x9b559dc,
                obstacleClearCounter = 0,
                time_to_gembox_drop = 100,
                time_in_gembox_period = 0x3bc40
            };
            this.respawnVars = vars;
            this.cooldowns = new Item[0];
            this.newShopBuildings = new uint[0x1c];
            this.newShopTraps = new uint[8];
            this.newShopDecos = new uint[0x25];
            this.last_league_rank = 0;
            this.last_league_shuffle = 0;
            this.last_news_seen = 10;
            this.edit_mode_shown = false;
            this.war_tutorials_seen = false;
            this.war_base = false;
        }

        public bool android_client { get; set; }

        public List<Item> buildings { get; set; }

        public Item[] cooldowns { get; set; }

        public Item[] decos { get; set; }

        public bool edit_mode_shown { get; set; }

        public uint last_league_rank { get; set; }

        public uint last_league_shuffle { get; set; }

        public uint last_news_seen { get; set; }

        public uint[] newShopBuildings { get; set; }

        public uint[] newShopDecos { get; set; }

        public uint[] newShopTraps { get; set; }

        public Item[] obstacles { get; set; }

        public RespawnVars respawnVars { get; set; }

        public Item[] traps { get; set; }

        public bool war_base { get; set; }

        public bool war_tutorials_seen { get; set; }
    }
}

