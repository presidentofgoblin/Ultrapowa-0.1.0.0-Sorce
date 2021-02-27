namespace Ultrapowa_Clash_Server.Database
{
    using System;
    using System.Runtime.CompilerServices;

    public class Clan
    {
        [CompilerGenerated]
        private int a;
        [CompilerGenerated]
        private DateTime b;
        [CompilerGenerated]
        private string c;

        public int ClanId
        {
            [CompilerGenerated]
            get
            {
                return this.a;
            }
            [CompilerGenerated]
            set
            {
                this.a = value;
            }
        }

        public DateTime LastUpdateTime
        {
            [CompilerGenerated]
            get
            {
                return this.b;
            }
            [CompilerGenerated]
            set
            {
                this.b = value;
            }
        }

        public string SerializedData
        {
            [CompilerGenerated]
            get
            {
                return this.c;
            }
            [CompilerGenerated]
            set
            {
                this.c = value;
            }
        }
    }
}

