using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Ultrapowa_Clash_Server.World;

internal class d : p
{
    [CompilerGenerated]
    private uint aa;
    [CompilerGenerated]
    private uint[,] ab;
    [CompilerGenerated]
    private Clan ac;
    [CompilerGenerated]
    private Player ad;
    [CompilerGenerated]
    private string ae;
    [CompilerGenerated]
    private uint u;
    [CompilerGenerated]
    private uint v;
    [CompilerGenerated]
    private uint w;
    [CompilerGenerated]
    private uint[,] x;
    [CompilerGenerated]
    private uint y;
    [CompilerGenerated]
    private uint[,] z;

    public d(af A_0) : base(A_0)
    {
        this.f4(0xbd8c);
        this.f1((uint) 0);
        this.f2((uint) 20);
        this.f2(new uint[this.f5(), 2]);
        for (uint i = 0; i < this.f5(); i++)
        {
            this.f0()[i, 0] = 0x1036640 + i;
            this.f0()[i, 1] = 1;
        }
        this.f3(0x15);
        this.f0(new uint[this.f7(), 2]);
        for (uint j = 0; j < this.f7(); j++)
        {
            this.ga()[j, 0] = 0x1036640 + j;
            this.ga()[j, 1] = 0xffff;
        }
        this.f0((uint) 20);
        this.f1(new uint[this.f1(), 2]);
        for (uint k = 0; k < this.f1(); k++)
        {
            this.f2()[k, 0] = 0x1036640 + k;
            this.f2()[k, 1] = 0xfff;
        }
    }

    public d(af A_0, Player A_1, Clan A_2) : this(A_0)
    {
        base.f1(0x5e25);
        base.f0((ushort) 0);
        this.f0(A_2);
        this.f0(A_1);
        this.f0(JsonConvert.SerializeObject(A_1.Village));
        this.f4();
        base.f0(1);
    }

    [CompilerGenerated]
    public uint[,] f0()
    {
        return this.x;
    }

    [CompilerGenerated]
    public void f0(uint[,] A_0)
    {
        this.z = A_0;
    }

    [CompilerGenerated]
    public void f0(string A_0)
    {
        this.ae = A_0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.aa = A_0;
    }

    [CompilerGenerated]
    public void f0(Clan A_0)
    {
        this.ac = A_0;
    }

    [CompilerGenerated]
    public void f0(Player A_0)
    {
        this.ad = A_0;
    }

    [CompilerGenerated]
    public uint f1()
    {
        return this.aa;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.v = A_0;
    }

    [CompilerGenerated]
    public void f1(uint[,] A_0)
    {
        this.ab = A_0;
    }

    [CompilerGenerated]
    public uint[,] f2()
    {
        return this.ab;
    }

    [CompilerGenerated]
    public void f2(uint A_0)
    {
        this.w = A_0;
    }

    [CompilerGenerated]
    public void f2(uint[,] A_0)
    {
        this.x = A_0;
    }

    [CompilerGenerated]
    public uint f3()
    {
        return this.v;
    }

    [CompilerGenerated]
    public void f3(uint A_0)
    {
        this.y = A_0;
    }

    public void f4()
    {
        List<byte> list = new List<byte>();
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f6())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f3())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gb().Region)));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gb().PlayerId)));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.f8().Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.f8()));
        list.AddRange(new byte[] { 0, 0, 0, 0, 0, 0, 4, 0xb0, 0, 0, 0, 60, 0, 0, 0, 0 });
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gb().Region)));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gb().PlayerId)));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gb().Region)));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gb().PlayerId)));
        list.Add(this.gb().FlagPlayerHasClan);
        if (this.gb().FlagPlayerHasClan == 1)
        {
            byte[] buffer = new byte[4];
            buffer[3] = 0x2a;
            list.AddRange(buffer);
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f9().ClanId)));
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.f9().ClanName.Length)));
            list.AddRange(Encoding.ASCII.GetBytes(this.f9().ClanName));
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f9().Shield)));
            list.AddRange(new byte[] { 
                0, 0, 0, 3, 1, 0, 0, 0, 0x2e, 0, 1, 0x11, 0x2d, 1, 0, 0, 
                0, 9, 0, 3, 0xe4, 0x1a, 0, 0, 0, 7, 0, 0, 0, 3
             });
        }
        else
        {
            list.AddRange(new byte[4]);
            list.AddRange(new byte[] { 0xff, 0xff, 0xff, 0xff });
        }
        byte[] collection = new byte[12];
        collection[11] = 2;
        list.AddRange(collection);
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.gb().PlayerName.Length)));
        list.AddRange(Encoding.ASCII.GetBytes(this.gb().PlayerName));
        list.AddRange(new byte[] { 0xff, 0xff, 0xff, 0xff });
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gb().Level)));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gb().Experience)));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gb().CurrentGems)));
        list.AddRange(new byte[] { 0, 0, 0, 0x17, 0, 0, 4, 0xb0, 0, 0, 0, 60 });
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gb().Trophies)));
        list.AddRange(new byte[] { 
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 
            220, 0x6c, 0xf5, 0xeb, 0x48
         });
        list.Add(this.gb().FlagPlayerHasName);
        list.AddRange(new byte[4]);
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.gb().MaxResources.get_Count())));
        foreach (KeyValuePair<uint, uint> pair in this.gb().MaxResources)
        {
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(pair.Key)));
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(pair.Value)));
        }
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.gb().CurrentResources.get_Count())));
        foreach (KeyValuePair<uint, uint> pair2 in this.gb().CurrentResources)
        {
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(pair2.Key)));
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(pair2.Value)));
        }
        list.AddRange(new byte[] { 
            0, 0, 0, 2, 0, 0x3d, 9, 0, 0, 0, 0, 6, 0, 0x3d, 9, 6, 
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
         });
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.gb().TutorialStepsCount)));
        for (uint i = 0; i < this.gb().TutorialStepsCount; i++)
        {
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) (0x1406f40 + i))));
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
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f5())));
        for (uint j = 0; j < this.f5(); j++)
        {
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f0()[j, 0])));
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f0()[j, 1])));
        }
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f7())));
        for (uint k = 0; k < this.f7(); k++)
        {
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.ga()[k, 0])));
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.ga()[k, 1])));
        }
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f1())));
        for (uint m = 0; m < this.f1(); m++)
        {
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f2()[m, 0])));
            list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.f2()[m, 1])));
        }
        list.AddRange(new byte[4]);
        base.f0(list.ToArray());
    }

    [CompilerGenerated]
    public void f4(uint A_0)
    {
        this.u = A_0;
    }

    [CompilerGenerated]
    public uint f5()
    {
        return this.w;
    }

    [CompilerGenerated]
    public uint f6()
    {
        return this.u;
    }

    [CompilerGenerated]
    public uint f7()
    {
        return this.y;
    }

    [CompilerGenerated]
    public string f8()
    {
        return this.ae;
    }

    [CompilerGenerated]
    public Clan f9()
    {
        return this.ac;
    }

    [CompilerGenerated]
    public uint[,] ga()
    {
        return this.z;
    }

    [CompilerGenerated]
    public Player gb()
    {
        return this.ad;
    }
}

