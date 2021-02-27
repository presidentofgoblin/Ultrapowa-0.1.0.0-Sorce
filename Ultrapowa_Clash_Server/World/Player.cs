namespace Ultrapowa_Clash_Server.World
{
    using System;
    using System.Collections.Concurrent;
    using System.Configuration;
    using System.Runtime.CompilerServices;

    internal class Player
    {
        public Player()
        {
        }

        public Player(uint playerId)
        {
            this.Login = playerId.ToString() + ((uint) DateTime.UtcNow.Subtract(new DateTime(0x7b2, 1, 1)).TotalSeconds).ToString();
            this.PlayerId = playerId;
            this.Region = 170;
            this.Village = null;
            this.FlagPlayerHasName = 0;
            this.Level = 9;
            this.ClanId = 0;
            this.Experience = 0x73;
            this.CurrentGems = Convert.ToUInt32(ConfigurationManager.AppSettings["startingGems"]);
            this.Trophies = 0x7d0;
            this.TutorialStepsCount = 10;
            this.MaxResources = new ConcurrentDictionary<uint, uint>();
            this.MaxResources.TryAdd(0x2dc6c1, 0x989680);
            this.MaxResources.TryAdd(0x2dc6c2, 0x1312d00);
            this.MaxResources.TryAdd(0x2dc6c3, 0x493e0);
            this.MaxResources.TryAdd(0x2dc6c4, 0x61a80);
            this.MaxResources.TryAdd(0x2dc6c5, 0x7a120);
            this.MaxResources.TryAdd(0x2dc6c6, 0x927c0);
            this.CurrentResources = new ConcurrentDictionary<uint, uint>();
            this.CurrentResources.TryAdd(0x2dc6c1, Convert.ToUInt32(ConfigurationManager.AppSettings["startingGold"]));
            this.CurrentResources.TryAdd(0x2dc6c2, Convert.ToUInt32(ConfigurationManager.AppSettings["startingElixir"]));
            this.CurrentResources.TryAdd(0x2dc6c3, 0x493e0);
            this.PlayerName = "NoNameYet";
            this.Village = new Ultrapowa_Clash_Server.World.Village(playerId);
        }

        public void AddBuilding(f ab)
        {
            Item item = new Item {
                data = ab.h(),
                lvl = 0,
                x = ab.f(),
                y = ab.e()
            };
            Building local1 = ac.d()[Tuple.Create<uint, int>(item.data, ((int) item.lvl) + 1)];
            item.const_t = 0;
            this.Village.buildings.Add(item);
        }

        public bool Authenticate()
        {
            return true;
        }

        public void CollectResources(al cr)
        {
        }

        public void UpdateBuildingPosition(i mb)
        {
            Item item = this.Village.buildings[(int) mb.h()];
            item.x = mb.f();
            item.y = mb.e();
            this.Village.buildings[(int) mb.h()] = item;
        }

        public void UpdateName(ai cpn)
        {
            this.PlayerName = cpn.f0();
            this.FlagPlayerHasName = 1;
            this.TutorialStepsCount = 13;
        }

        public void UpgradeBuilding(aa ub)
        {
            Item item = this.Village.buildings[(int) ub.d()];
            item.lvl++;
            item.const_t = 0x2710;
            this.Village.buildings[(int) ub.d()] = item;
        }

        public uint ClanId { get; set; }

        public uint CurrentGems { get; set; }

        public ConcurrentDictionary<uint, uint> CurrentResources { get; set; }

        public uint Experience { get; set; }

        public byte FlagPlayerHasClan
        {
            get
            {
                if (this.ClanId <= 0)
                {
                    return 0;
                }
                return 1;
            }
        }

        public byte FlagPlayerHasName { get; set; }

        public uint Level { get; set; }

        public string Login { get; set; }

        public ConcurrentDictionary<uint, uint> MaxResources { get; set; }

        public uint PlayerId { get; set; }

        public string PlayerName { get; set; }

        public uint Region { get; set; }

        public uint Trophies { get; set; }

        public uint TutorialStepsCount { get; set; }

        public Ultrapowa_Clash_Server.World.Village Village { get; set; }
    }
}

