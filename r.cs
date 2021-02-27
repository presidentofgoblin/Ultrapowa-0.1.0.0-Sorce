using System;
using System.IO;
using System.Runtime.CompilerServices;
using Ultrapowa_Clash_Server.Helpers;

internal class r : p
{
    [CompilerGenerated]
    private string c0;
    [CompilerGenerated]
    private uint c1;
    [CompilerGenerated]
    private string c2;
    [CompilerGenerated]
    private uint c3;
    [CompilerGenerated]
    private uint c4;
    [CompilerGenerated]
    private string c5;
    [CompilerGenerated]
    private uint c6;
    [CompilerGenerated]
    private string c7;
    [CompilerGenerated]
    private uint c8;
    [CompilerGenerated]
    private string c9;
    [CompilerGenerated]
    private uint cn;
    [CompilerGenerated]
    private uint co;
    [CompilerGenerated]
    private uint cp;
    [CompilerGenerated]
    private string cq;
    [CompilerGenerated]
    private uint cr;
    [CompilerGenerated]
    private uint cs;
    [CompilerGenerated]
    private uint ct;
    [CompilerGenerated]
    private uint cu;
    [CompilerGenerated]
    private string cv;
    [CompilerGenerated]
    private uint cw;
    [CompilerGenerated]
    private uint cx;
    [CompilerGenerated]
    private string cy;
    [CompilerGenerated]
    private uint cz;
    [CompilerGenerated]
    private byte da;
    [CompilerGenerated]
    private uint db;
    [CompilerGenerated]
    private uint dc;
    [CompilerGenerated]
    private string dd;
    [CompilerGenerated]
    private uint de;
    [CompilerGenerated]
    private byte df;
    [CompilerGenerated]
    private uint dg;
    [CompilerGenerated]
    private string dh;
    [CompilerGenerated]
    private uint di;
    [CompilerGenerated]
    private string dj;

    public r(p A_0) : this(A_0.g9(), A_0.g2())
    {
    }

    public r(af A_0, byte[] A_1) : base(A_0, A_1)
    {
        MemoryStream input = new MemoryStream(base.g6());
        BinaryReader br = new BinaryReader(input);
        this.f6(br.ReadUInt32WithEndian());
        this.gg(br.ReadUInt32WithEndian());
        this.gd(br.ReadUInt32WithEndian());
        if (this.f3() != uint.MaxValue)
        {
            this.f1(br.ReadString(this.f3()));
        }
        else
        {
            this.f1((string) null);
        }
        this.gi(br.ReadUInt32WithEndian());
        this.gb(br.ReadUInt32WithEndian());
        this.f1(br.ReadUInt32WithEndian());
        this.f7(br.ReadUInt32WithEndian());
        this.f3(br.ReadString(this.go()));
        this.f2(br.ReadUInt32WithEndian());
        this.ge(br.ReadUInt32WithEndian());
        if (this.gw() != uint.MaxValue)
        {
            this.f0(br.ReadString(this.gw()));
        }
        else
        {
            this.f0((string) null);
        }
        this.f3(br.ReadUInt32WithEndian());
        if ((this.gh() != uint.MaxValue) && (this.gh() != 0))
        {
            this.f2(br.ReadString(this.gh()));
        }
        else
        {
            this.f2((string) null);
        }
        this.ga(br.ReadUInt32WithEndian());
        if (this.gc() != uint.MaxValue)
        {
            this.f6(br.ReadString(this.gc()));
        }
        else
        {
            this.f6((string) null);
        }
        this.f5(br.ReadUInt32WithEndian());
        this.gc(br.ReadUInt32WithEndian());
        if (this.gl() != uint.MaxValue)
        {
            this.f8(br.ReadString(this.gl()));
        }
        else
        {
            this.f8((string) null);
        }
        this.f9(br.ReadUInt32WithEndian());
        if (this.gk() != uint.MaxValue)
        {
            this.ga(br.ReadString(this.gk()));
        }
        this.gh(br.ReadUInt32WithEndian());
        if (this.gr() != uint.MaxValue)
        {
            this.f7(br.ReadString(this.gr()));
        }
        else
        {
            this.f7((string) null);
        }
        this.f0(br.ReadByte());
        this.gf(br.ReadUInt32WithEndian());
        this.f4(br.ReadUInt32WithEndian());
        if ((this.gd() != uint.MaxValue) && (this.gd() != 0))
        {
            this.f4(br.ReadString(this.gd()));
        }
        else
        {
            this.f4((string) null);
        }
        this.f0(br.ReadUInt32WithEndian());
        if ((this.f4() != uint.MaxValue) && (this.f4() != 0))
        {
            this.f5(br.ReadString(this.f4()));
        }
        else
        {
            this.f5((string) null);
        }
        this.f1(br.ReadByte());
        this.gj(br.ReadUInt32WithEndian());
        if ((this.gi() != uint.MaxValue) && (this.gi() != 0))
        {
            this.f9(br.ReadString(this.gi()));
        }
        else
        {
            this.f9((string) null);
        }
    }

    [CompilerGenerated]
    public string f0()
    {
        return this.dh;
    }

    [CompilerGenerated]
    public void f0(byte A_0)
    {
        this.da = A_0;
    }

    [CompilerGenerated]
    public void f0(string A_0)
    {
        this.cy = A_0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.dg = A_0;
    }

    [CompilerGenerated]
    public string f1()
    {
        return this.dd;
    }

    [CompilerGenerated]
    public void f1(byte A_0)
    {
        this.df = A_0;
    }

    [CompilerGenerated]
    public void f1(string A_0)
    {
        this.cq = A_0;
    }

    [CompilerGenerated]
    public void f1(uint A_0)
    {
        this.ct = A_0;
    }

    [CompilerGenerated]
    public byte f2()
    {
        return this.df;
    }

    [CompilerGenerated]
    public void f2(string A_0)
    {
        this.c0 = A_0;
    }

    [CompilerGenerated]
    public void f2(uint A_0)
    {
        this.cw = A_0;
    }

    [CompilerGenerated]
    public uint f3()
    {
        return this.cp;
    }

    [CompilerGenerated]
    public void f3(string A_0)
    {
        this.cv = A_0;
    }

    [CompilerGenerated]
    public void f3(uint A_0)
    {
        this.cz = A_0;
    }

    [CompilerGenerated]
    public uint f4()
    {
        return this.dg;
    }

    [CompilerGenerated]
    public void f4(string A_0)
    {
        this.dd = A_0;
    }

    [CompilerGenerated]
    public void f4(uint A_0)
    {
        this.dc = A_0;
    }

    [CompilerGenerated]
    public uint f5()
    {
        return this.de;
    }

    [CompilerGenerated]
    public void f5(string A_0)
    {
        this.dh = A_0;
    }

    [CompilerGenerated]
    public void f5(uint A_0)
    {
        this.c3 = A_0;
    }

    [CompilerGenerated]
    public uint f6()
    {
        return this.db;
    }

    [CompilerGenerated]
    public void f6(string A_0)
    {
        this.c2 = A_0;
    }

    [CompilerGenerated]
    public void f6(uint A_0)
    {
        this.cn = A_0;
    }

    [CompilerGenerated]
    public string f7()
    {
        return this.c7;
    }

    [CompilerGenerated]
    public void f7(string A_0)
    {
        this.c9 = A_0;
    }

    [CompilerGenerated]
    public void f7(uint A_0)
    {
        this.cu = A_0;
    }

    [CompilerGenerated]
    public uint f8()
    {
        return this.ct;
    }

    [CompilerGenerated]
    public void f8(string A_0)
    {
        this.c5 = A_0;
    }

    [CompilerGenerated]
    public void f8(uint A_0)
    {
        this.de = A_0;
    }

    [CompilerGenerated]
    public string f9()
    {
        return this.c2;
    }

    [CompilerGenerated]
    public void f9(string A_0)
    {
        this.dj = A_0;
    }

    [CompilerGenerated]
    public void f9(uint A_0)
    {
        this.c6 = A_0;
    }

    [CompilerGenerated]
    public uint ga()
    {
        return this.co;
    }

    [CompilerGenerated]
    public void ga(string A_0)
    {
        this.c7 = A_0;
    }

    [CompilerGenerated]
    public void ga(uint A_0)
    {
        this.c1 = A_0;
    }

    [CompilerGenerated]
    public string gb()
    {
        return this.cy;
    }

    [CompilerGenerated]
    public void gb(uint A_0)
    {
        this.cs = A_0;
    }

    [CompilerGenerated]
    public uint gc()
    {
        return this.c1;
    }

    [CompilerGenerated]
    public void gc(uint A_0)
    {
        this.c4 = A_0;
    }

    [CompilerGenerated]
    public uint gd()
    {
        return this.dc;
    }

    [CompilerGenerated]
    public void gd(uint A_0)
    {
        this.cp = A_0;
    }

    [CompilerGenerated]
    public string ge()
    {
        return this.c5;
    }

    [CompilerGenerated]
    public void ge(uint A_0)
    {
        this.cx = A_0;
    }

    [CompilerGenerated]
    public string gf()
    {
        return this.c0;
    }

    [CompilerGenerated]
    public void gf(uint A_0)
    {
        this.db = A_0;
    }

    [CompilerGenerated]
    public uint gg()
    {
        return this.cr;
    }

    [CompilerGenerated]
    public void gg(uint A_0)
    {
        this.co = A_0;
    }

    [CompilerGenerated]
    public uint gh()
    {
        return this.cz;
    }

    [CompilerGenerated]
    public void gh(uint A_0)
    {
        this.c8 = A_0;
    }

    [CompilerGenerated]
    public uint gi()
    {
        return this.di;
    }

    [CompilerGenerated]
    public void gi(uint A_0)
    {
        this.cr = A_0;
    }

    [CompilerGenerated]
    public string gj()
    {
        return this.c9;
    }

    [CompilerGenerated]
    public void gj(uint A_0)
    {
        this.di = A_0;
    }

    [CompilerGenerated]
    public uint gk()
    {
        return this.c6;
    }

    [CompilerGenerated]
    public uint gl()
    {
        return this.c4;
    }

    [CompilerGenerated]
    public string gm()
    {
        return this.cq;
    }

    [CompilerGenerated]
    public uint gn()
    {
        return this.cw;
    }

    [CompilerGenerated]
    public uint go()
    {
        return this.cu;
    }

    [CompilerGenerated]
    public string gp()
    {
        return this.cv;
    }

    [CompilerGenerated]
    public uint gq()
    {
        return this.cs;
    }

    [CompilerGenerated]
    public uint gr()
    {
        return this.c8;
    }

    [CompilerGenerated]
    public uint gs()
    {
        return this.cn;
    }

    [CompilerGenerated]
    public string gt()
    {
        return this.dj;
    }

    [CompilerGenerated]
    public byte gu()
    {
        return this.da;
    }

    [CompilerGenerated]
    public uint gv()
    {
        return this.c3;
    }

    [CompilerGenerated]
    public uint gw()
    {
        return this.cx;
    }
}

