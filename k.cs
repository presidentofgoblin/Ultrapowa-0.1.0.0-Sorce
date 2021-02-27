using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

internal class k : p
{
    [CompilerGenerated]
    private uint a6;
    [CompilerGenerated]
    private string a7;
    [CompilerGenerated]
    private uint a8;
    [CompilerGenerated]
    private string a9;
    [CompilerGenerated]
    private uint ba;
    [CompilerGenerated]
    private byte bb;
    [CompilerGenerated]
    private uint bc;
    [CompilerGenerated]
    private uint[] bd;
    [CompilerGenerated]
    private uint be;
    [CompilerGenerated]
    private uint[,] bf;
    [CompilerGenerated]
    private uint bg;
    [CompilerGenerated]
    private uint[,] bh;
    [CompilerGenerated]
    private uint bi;
    [CompilerGenerated]
    private uint[,] bj;
    [CompilerGenerated]
    private uint bk;

    public k(af A_0) : base(A_0)
    {
        base.f1(0x5e45);
        base.f0((ushort) 0);
        this.f1("{\"buildings\":[{\"data\":1000001,\"lvl\":1,\"x\":22,\"y\":16},{\"data\":1000009,\"lvl\":0,\"x\":23,\"y\":21},{\"data\":1000010,\"lvl\":0,\"x\":26,\"y\":23},{\"data\":1000010,\"lvl\":0,\"x\":26,\"y\":22},{\"data\":1000010,\"lvl\":0,\"x\":26,\"y\":21},{\"data\":1000010,\"lvl\":0,\"x\":26,\"y\":20},{\"data\":1000010,\"lvl\":0,\"x\":26,\"y\":19},{\"data\":1000010,\"lvl\":0,\"x\":26,\"y\":18},{\"data\":1000010,\"lvl\":0,\"x\":26,\"y\":17},{\"data\":1000010,\"lvl\":0,\"x\":26,\"y\":16},{\"data\":1000010,\"lvl\":0,\"x\":26,\"y\":15},{\"data\":1000010,\"lvl\":0,\"x\":25,\"y\":15},{\"data\":1000010,\"lvl\":0,\"x\":26,\"y\":24},{\"data\":1000010,\"lvl\":0,\"x\":25,\"y\":24},{\"data\":1000010,\"lvl\":0,\"x\":24,\"y\":24},{\"data\":1000010,\"lvl\":0,\"x\":24,\"y\":15},{\"data\":1000018,\"lvl\":0,\"x\":19,\"y\":19,\"units\":[],\"storage_type\":0}],\"obstacles\":[{\"data\":8000000,\"x\":21,\"y\":12,\"loot_multiply_ver\":1},{\"data\":8000000,\"x\":10,\"y\":15,\"loot_multiply_ver\":1},{\"data\":8000000,\"x\":25,\"y\":12,\"loot_multiply_ver\":1},{\"data\":8000000,\"x\":23,\"y\":12,\"loot_multiply_ver\":1},{\"data\":8000020,\"x\":18,\"y\":11,\"loot_multiply_ver\":1},{\"data\":8000020,\"x\":13,\"y\":20,\"loot_multiply_ver\":1},{\"data\":8000020,\"x\":13,\"y\":17,\"loot_multiply_ver\":1},{\"data\":8000020,\"x\":27,\"y\":11,\"loot_multiply_ver\":1},{\"data\":8000019,\"x\":29,\"y\":13,\"loot_multiply_ver\":1},{\"data\":8000019,\"x\":15,\"y\":11,\"loot_multiply_ver\":1}],\"traps\":[],\"decos\":[{\"data\":18000001,\"x\":22,\"y\":24},{\"data\":18000001,\"x\":22,\"y\":14},{\"data\":18000002,\"x\":17,\"y\":15},{\"data\":18000007,\"x\":17,\"y\":23}],\"respawnVars\":{\"secondsFromLastRespawn\":3600,\"respawnSeed\":162879964,\"obstacleClearCounter\":0,\"time_to_gembox_drop\":360000,\"time_in_gembox_period\":244800},\"cooldowns\":[],\"newShopBuildings\":[1,0,2,1,2,1,2,0,2,1,25,0,0,0,1,5,0,0,0,0,0,0,0,0,0,0,0,0],\"newShopTraps\":[0,0,0,0,0,0,0,0],\"newShopDecos\":[1,4,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0],\"last_league_rank\":0,\"last_league_shuffle\":0,\"last_news_seen\":-1,\"edit_mode_shown\":false}");
        this.f1((uint) this.f7().Length);
        this.f0("michael jackson");
        this.f5((uint) this.f6().Length);
        this.f0((uint) 8);
        this.f0((byte) 1);
        this.f7(10);
        this.f0(new uint[this.gc()]);
        for (uint i = 0; i < this.gc(); i++)
        {
            this.gb()[i] = 0x1406f40 + i;
        }
        this.f4(20);
        this.f2(new uint[this.f9(), 2]);
        for (uint j = 0; j < this.f9(); j++)
        {
            this.f0()[j, 0] = 0x1036640 + j;
            this.f0()[j, 1] = 1;
        }
        this.f6(0x15);
        this.f0((uint[,]) new uint[this.ga(), 2]);
        for (uint k = 0; k < this.ga(); k++)
        {
            this.ge()[k, 0] = 0x1036640 + k;
            this.ge()[k, 1] = 0xffff;
        }
        this.f3(20);
        this.f1(new uint[this.f5(), 2]);
        for (uint m = 0; m < this.f5(); m++)
        {
            this.f3()[m, 0] = 0x1036640 + m;
            this.f3()[m, 1] = 0xfff;
        }
        this.f2((uint) 0x1036641);
        this.f8();
        base.f0(1);
    }

    public k(p A_0) : this(A_0.g9())
    {
    }

    [CompilerGenerated]
    public uint[,] f0()
    {
        return this.bf;
    }

    [CompilerGenerated]
    public void f0(byte A_0)
    {
        this.bb = A_0;
    }

    [CompilerGenerated]
    public void f0(string A_0)
    {
        this.a9 = A_0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.ba = A_0;
    }

    [CompilerGenerated]
    public void f0(uint[] A_0)
    {
        this.bd = A_0;
    }

    [CompilerGenerated]
    public void f0(uint[,] A_0)
    {
        this.bh = A_0;
    }

    [CompilerGenerated]
    public uint f1()
    {
        return this.bk;
    }

    [CompilerGenerated]
    public void f1(string A_0)
    {
        this.a7 = A_0;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.a6 = A_0;
    }

    [CompilerGenerated]
    public void f1(uint[,] A_0)
    {
        this.bj = A_0;
    }

    [CompilerGenerated]
    public uint f2()
    {
        return this.a6;
    }

    [CompilerGenerated]
    public void f2(uint[,] A_0)
    {
        this.bf = A_0;
    }

    [CompilerGenerated]
    public void f2(uint A_0)
    {
        this.bk = A_0;
    }

    [CompilerGenerated]
    public uint[,] f3()
    {
        return this.bj;
    }

    [CompilerGenerated]
    public void f3(uint A_0)
    {
        this.bi = A_0;
    }

    [CompilerGenerated]
    public uint f4()
    {
        return this.ba;
    }

    [CompilerGenerated]
    public void f4(uint A_0)
    {
        this.be = A_0;
    }

    [CompilerGenerated]
    public uint f5()
    {
        return this.bi;
    }

    [CompilerGenerated]
    public void f5(uint A_0)
    {
        this.a8 = A_0;
    }

    [CompilerGenerated]
    public string f6()
    {
        return this.a9;
    }

    [CompilerGenerated]
    public void f6(uint A_0)
    {
        this.bg = A_0;
    }

    [CompilerGenerated]
    public string f7()
    {
        return this.a7;
    }

    [CompilerGenerated]
    public void f7(uint A_0)
    {
        this.bc = A_0;
    }

    public void f8()
    {
        List<byte> list = new List<byte>();
        list.AddRange(new byte[4]);
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f2())));
        list.AddRange(Encoding.ASCII.GetBytes(this.f7()));
        list.AddRange(new byte[] { 
            0, 0, 0, 0, 0, 0, 0, 0x2a, 0, 0x15, 0xd8, 0, 0, 0, 0, 0x2a, 
            0, 0x15, 0xd8, 0, 0, 0, 0, 0, 0, 0xff, 0xff, 0xff, 0xff, 0, 0, 0, 
            0, 0, 0, 0, 0, 0, 0, 0, 4
         });
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gd())));
        list.AddRange(Encoding.ASCII.GetBytes(this.f6()));
        list.AddRange(new byte[] { 0xff, 0xff, 0xff, 0xff });
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f4())));
        list.AddRange(new byte[] { 
            0, 0, 1, 0x16, 0, 15, 0xff, 0xff, 0, 0, 0, 0x17, 0, 0, 4, 0xb0, 
            0, 0, 0, 60, 0, 0, 15, 0xff, 0, 0, 0, 0, 0, 0, 0, 0, 
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
            0, 0, 0, 0, 1, 0, 0, 0, 220, 0x6c, 0xf5, 0xeb, 0x48
         });
        list.Add(this.gf());
        list.AddRange(new byte[] { 
            0, 0, 0, 0, 0, 0, 0, 6, 0, 0x2d, 0xc6, 0xc1, 0, 0, 0x65, 0x90, 
            0, 0x2d, 0xc6, 0xc2, 0, 0, 0x1b, 0x58, 0, 0x2d, 0xc6, 0xc3, 0, 0, 0, 0, 
            0, 0x2d, 0xc6, 0xc4, 0, 1, 0x24, 0xf8, 0, 0x2d, 0xc6, 0xc5, 0, 1, 0x24, 0xf8, 
            0, 0x2d, 0xc6, 0xc6, 0, 0, 0, 100, 0, 0, 0, 2, 0, 0x2d, 0xc6, 0xc1, 
            15, 0xff, 0x2e, 0x7c, 0, 0x2d, 0xc6, 0xc2, 15, 0xff, 0x1b, 0x58, 0, 0, 0, 2, 
            0, 0x3d, 9, 0, 0, 0, 0, 6, 0, 0x3d, 9, 6, 0, 0, 0, 0, 
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
         });
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gc())));
        for (uint i = 0; i < this.gc(); i++)
        {
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gb()[i])));
        }
        list.AddRange(new byte[] { 
            0, 0, 0, 2, 1, 0x5e, 0xf3, 0xc3, 1, 0x5e, 0xf3, 0xcc, 0, 0, 0, 0x1c, 
            1, 0x5e, 0xf3, 0xc0, 0, 0, 0, 5, 1, 0x5e, 0xf3, 0xc1, 0, 0, 0, 5, 
            1, 0x5e, 0xf3, 0xc2, 0, 0, 0, 5, 1, 0x5e, 0xf3, 0xc3, 0, 0, 0, 0x17, 
            1, 0x5e, 0xf3, 0xc4, 0, 0, 0, 0x17, 1, 0x5e, 0xf3, 0xc5, 0, 0, 0, 0x17, 
            1, 0x5e, 0xf3, 0xc6, 0, 0, 0, 3, 1, 0x5e, 0xf3, 0xc7, 0, 0, 0, 3, 
            1, 0x5e, 0xf3, 200, 0, 0, 0, 3, 1, 0x5e, 0xf3, 0xc9, 0, 0, 0, 3, 
            1, 0x5e, 0xf3, 0xca, 0, 0, 0, 3, 1, 0x5e, 0xf3, 0xcb, 0, 0, 0, 3, 
            1, 0x5e, 0xf3, 0xcc, 0, 0, 0, 1, 1, 0x5e, 0xf3, 0xcf, 0, 0, 0x2c, 6, 
            1, 0x5e, 0xf3, 0xd0, 0, 0, 0x2c, 6, 1, 0x5e, 0xf3, 0xd1, 0, 0, 0x2c, 6, 
            1, 0x5e, 0xf3, 210, 0, 0, 0x21, 0xcb, 1, 0x5e, 0xf3, 0xd3, 0, 0, 0x21, 0xcb, 
            1, 0x5e, 0xf3, 0xd4, 0, 0, 0x21, 0xcb, 1, 0x5e, 0xf3, 0xd5, 0, 0, 0, 20, 
            1, 0x5e, 0xf3, 0xd6, 0, 0, 0, 20, 1, 0x5e, 0xf3, 0xd7, 0, 0, 0, 20, 
            1, 0x5e, 0xf3, 0xe1, 0, 0, 0, 1, 1, 0x5e, 0xf3, 0xe2, 0, 0, 0, 1, 
            1, 0x5e, 0xf3, 0xe3, 0, 0, 0, 1, 1, 0x5e, 0xf3, 0xe7, 0, 0, 0, 1, 
            1, 0x5e, 0xf3, 0xe8, 0, 0, 0, 1, 1, 0x5e, 0xf3, 0xe9, 0, 0, 0, 1
         });
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f9())));
        for (uint j = 0; j < this.f9(); j++)
        {
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f0()[j, 0])));
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f0()[j, 1])));
        }
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.ga())));
        for (uint k = 0; k < this.ga(); k++)
        {
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.ge()[k, 0])));
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.ge()[k, 1])));
        }
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f5())));
        for (uint m = 0; m < this.f5(); m++)
        {
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f3()[m, 0])));
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f3()[m, 1])));
        }
        list.AddRange(new byte[4]);
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f1())));
        base.f0(list.ToArray());
    }

    [CompilerGenerated]
    public uint f9()
    {
        return this.be;
    }

    [CompilerGenerated]
    public uint ga()
    {
        return this.bg;
    }

    [CompilerGenerated]
    public uint[] gb()
    {
        return this.bd;
    }

    [CompilerGenerated]
    public uint gc()
    {
        return this.bc;
    }

    [CompilerGenerated]
    public uint gd()
    {
        return this.a8;
    }

    [CompilerGenerated]
    public uint[,] ge()
    {
        return this.bh;
    }

    [CompilerGenerated]
    public byte gf()
    {
        return this.bb;
    }
}

