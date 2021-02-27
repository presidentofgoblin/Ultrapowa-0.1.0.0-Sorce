using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

internal class p
{
    [CompilerGenerated]
    private ushort b7;
    [CompilerGenerated]
    private af b8;
    [CompilerGenerated]
    private byte[] b9;
    [CompilerGenerated]
    private ushort ca;
    [CompilerGenerated]
    private int cb;

    public p()
    {
    }

    public p(af A_0)
    {
        this.f0(A_0);
        this.f1(0);
        this.f0((ushort) 0);
        this.f0((byte[]) null);
        this.f0(1);
    }

    public p(af A_0, byte[] A_1)
    {
        int num;
        this.f0(A_0);
        this.f1((ushort) ((A_1[0] << 8) | A_1[1]));
        if (A_1.Length >= 2)
        {
            num = ((A_1[2] << 0x10) | (A_1[3] << 8)) | A_1[4];
            this.f0((ushort) ((A_1[5] << 8) | A_1[6]));
        }
        else
        {
            num = 0;
            this.f0((ushort) 0);
        }
        this.f0(new byte[num]);
        Array.Copy(A_1, 7, this.g6(), 0, num);
        this.f0(1);
    }

    [CompilerGenerated]
    public void f0(af A_0)
    {
        this.b8 = A_0;
    }

    [CompilerGenerated]
    public void f0(byte[] A_0)
    {
        this.b9 = A_0;
    }

    [CompilerGenerated]
    public void f0(int A_0)
    {
        this.cb = A_0;
    }

    [CompilerGenerated]
    public void f0(ushort A_0)
    {
        this.ca = A_0;
    }

    [CompilerGenerated]
    public void f1(ushort A_0)
    {
        this.b7 = A_0;
    }

    public byte[] g2()
    {
        List<byte> list = new List<byte>();
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.g7())));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.g3())).Skip<byte>(1));
        list.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(this.g8())));
        list.AddRange(this.g6());
        return list.ToArray();
    }

    public int g3()
    {
        return this.g6().Length;
    }

    public string g4()
    {
        return BitConverter.ToString(this.g6()).Replace("-", " ");
    }

    [CompilerGenerated]
    public int g5()
    {
        return this.cb;
    }

    [CompilerGenerated]
    public byte[] g6()
    {
        return this.b9;
    }

    [CompilerGenerated]
    public ushort g7()
    {
        return this.b7;
    }

    [CompilerGenerated]
    public ushort g8()
    {
        return this.ca;
    }

    [CompilerGenerated]
    public af g9()
    {
        return this.b8;
    }

    public override string ToString()
    {
        return Encoding.UTF8.GetString(this.g6(), 0, this.g3());
    }
}

