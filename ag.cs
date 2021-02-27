using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Ultrapowa_Clash_Server.World;

internal class ag : p
{
    [CompilerGenerated]
    private uint fk;
    [CompilerGenerated]
    private ConcurrentQueue<ClanChatMessage> fl;

    public ag(af A_0, Clan A_1) : base(A_0)
    {
        Action<ClanChatMessage> action = null;
        base.f1(0x5ef7);
        base.f0((ushort) 0);
        this.f0(new ConcurrentQueue<ClanChatMessage>());
        if (action == null)
        {
            action = new Action<ClanChatMessage>(this.f0);
        }
        Enumerable.Take<ClanChatMessage>(A_1.ChatHistory, 30).ToList<ClanChatMessage>().ForEach(action);
        this.f0();
        base.f0(1);
    }

    public void f0()
    {
        ag.a a = new ag.a {
            a = new List<byte>()
        };
        a.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes((uint) this.f2().get_Count())));
        this.f2().ToList<ClanChatMessage>().ForEach(new Action<ClanChatMessage>(a.b));
        base.f0(a.a.ToArray());
    }

    [CompilerGenerated]
    public void f0(ConcurrentQueue<ClanChatMessage> A_0)
    {
        this.fl = A_0;
    }

    [CompilerGenerated]
    public void f0(uint A_0)
    {
        this.fk = A_0;
    }

    [CompilerGenerated]
    private void f0(ClanChatMessage A_0)
    {
        this.f2().Enqueue(A_0);
    }

    [CompilerGenerated]
    public uint f1()
    {
        return this.fk;
    }

    [CompilerGenerated]
    public ConcurrentQueue<ClanChatMessage> f2()
    {
        return this.fl;
    }

    [CompilerGenerated]
    private sealed class a
    {
        public List<byte> a;

        public void b(ClanChatMessage A_0)
        {
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.Unknown1)));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.Unknown2)));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.ServerTick)));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.Region1)));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.PlayerId1)));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.Region2)));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.PlayerId2)));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.PlayerName.Length)));
            this.a.AddRange(Encoding.ASCII.GetBytes(A_0.PlayerName));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.Unknown3)));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.Unknown4)));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.MemberStatus)));
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.TimeFromMessage)));
            this.a.Add(A_0.Unknown5);
            this.a.AddRange(Enumerable.Reverse<byte>(BitConverter.GetBytes(A_0.Message.Length)));
            this.a.AddRange(Encoding.ASCII.GetBytes(A_0.Message));
        }
    }
}

