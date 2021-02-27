using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Ultrapowa_Clash_Server.Helpers;
using Ultrapowa_Clash_Server.World;

internal class aj
{
    private static ConcurrentQueue<p> a = new ConcurrentQueue<p>();
    private static EventWaitHandle b = new AutoResetEvent(false);
    private bool c = false;
    [CompilerGenerated]
    private static Func<KeyValuePair<uint, Clan>, uint> d;
    [CompilerGenerated]
    private static Func<KeyValuePair<uint, Clan>, Clan> e;

    private void a()
    {
        while (this.c)
        {
            p p;
            aj.b.WaitOne();
            while (aj.a.TryDequeue(ref p))
            {
                switch (p.g7())
                {
                    case 0x3736:
                    {
                        k k = new k(p);
                        n.a(k);
                        continue;
                    }
                    case 0x3738:
                    case 0x37e2:
                    case 0x37f2:
                    {
                        continue;
                    }
                    case 0x3716:
                    {
                        ak ak = new ak(p);
                        for (int i = 0; i < ak.f1(); i++)
                        {
                            uint num2 = ak.f2().ReadUInt32WithEndian();
                            switch (num2)
                            {
                                case 500:
                                {
                                    Player player3 = ac.c(p.g9());
                                    f ab = new f(ak.f2());
                                    player3.AddBuilding(ab);
                                    continue;
                                }
                                case 0x1f5:
                                {
                                    ac.c(p.g9()).UpdateBuildingPosition(new i(ak.f2()));
                                    continue;
                                }
                                case 0x1f6:
                                {
                                    ac.c(p.g9()).UpgradeBuilding(new aa(ak.f2()));
                                    continue;
                                }
                                case 0x1fa:
                                {
                                    ac.c(p.g9()).CollectResources(new al(ak.f2()));
                                    continue;
                                }
                            }
                            Console.WriteLine("Unknown command " + num2.ToString() + ". Ignored.");
                        }
                        continue;
                    }
                    case 0x2775:
                    {
                        r r = new r(p);
                        if (r.gp() != ac.c().sha)
                        {
                            n.a(new t(p.g9(), ac.c().ToJson()));
                        }
                        else
                        {
                            Clan clan;
                            Player player = ac.c(r.ga());
                            if (player == null)
                            {
                                if (r.ga() == 0)
                                {
                                    player = new Player(ac.l());
                                }
                                else
                                {
                                    player = new Player(r.ga());
                                }
                            }
                            ac.c(player, p.g9());
                            ac.e().TryGetValue(player.ClanId, ref clan);
                            n.a(new ad(p.g9(), player));
                            n.a(new d(p.g9(), player, clan));
                            if (clan != null)
                            {
                                n.a(new ag(p.g9(), clan));
                            }
                        }
                        continue;
                    }
                    case 0x27e4:
                    {
                        Player player2 = ac.c(p.g9());
                        player2.UpdateName(new ai(p));
                        n.a(new z(p.g9(), player2));
                        continue;
                    }
                    case 0x37dd:
                    {
                        Player player7;
                        Clan clan2 = new Clan(new ah(p));
                        lock (ac.e())
                        {
                            clan2.ClanId = (uint) (ac.e().get_Count() + 1);
                            ac.e().TryAdd(clan2.ClanId, clan2);
                        }
                        ac.i().TryGetValue(p.g9(), ref player7);
                        player7.ClanId = clan2.ClanId;
                        n.a(new o(p.g9(), clan2));
                        continue;
                    }
                    case 0x37de:
                    {
                        Clan clan3;
                        a a = new a(p);
                        ac.e().TryGetValue(a.f1(), ref clan3);
                        n.a(new s(p.g9(), clan3, a.f0()));
                        continue;
                    }
                    case 0x37df:
                    {
                        if (d == null)
                        {
                            d = new Func<KeyValuePair<uint, Clan>, uint>(null, (IntPtr) aj.b);
                        }
                        if (e == null)
                        {
                            e = new Func<KeyValuePair<uint, Clan>, Clan>(null, (IntPtr) aj.a);
                        }
                        n.a(new q(p.g9(), Enumerable.Take<Clan>(Enumerable.Select<KeyValuePair<uint, Clan>, Clan>(Enumerable.OrderByDescending<KeyValuePair<uint, Clan>, uint>(ac.e(), d), e), 15).ToList<Clan>()));
                        continue;
                    }
                    case 0x37e1:
                    {
                        h h = new h(p);
                        Clan clan4 = null;
                        ac.e().TryGetValue(h.f0(), ref clan4);
                        if (clan4 != null)
                        {
                            Player player8;
                            ac.i().TryGetValue(p.g9(), ref player8);
                            player8.ClanId = clan4.ClanId;
                            n.a(new b(p.g9(), clan4));
                            n.a(new ag(p.g9(), clan4));
                        }
                        continue;
                    }
                    case 0x37e4:
                    {
                        Player player9;
                        Clan clan5;
                        ac.i().TryGetValue(p.g9(), ref player9);
                        ac.e().TryGetValue(player9.ClanId, ref clan5);
                        player9.ClanId = 0;
                        n.a(new m(p.g9(), clan5));
                        continue;
                    }
                    case 0x37eb:
                    {
                        Player player10;
                        ac.i().TryGetValue(p.g9(), ref player10);
                        if (player10.ClanId > 0)
                        {
                            ClanChatMessage message = new ClanChatMessage(new y(p), player10);
                            ac.e().get_Item(player10.ClanId).ChatHistory.Enqueue(message);
                            n.a(new g(p.g9(), message));
                        }
                        continue;
                    }
                    case 0x37f4:
                    {
                        aj.b b = new aj.b {
                            a = new v(p)
                        };
                        n.a(new c(p.g9(), b.a.f1(), Enumerable.Take<Clan>(Enumerable.Where<Clan>(ac.e().get_Values(), new Func<Clan, bool>(b, (IntPtr) this.b)), 15).ToList<Clan>()));
                        continue;
                    }
                    case 0x397b:
                    {
                        Player player11;
                        ac.i().TryGetValue(p.g9(), ref player11);
                        n.a(new e(p.g9(), player11, new j(p)));
                        continue;
                    }
                }
                Console.WriteLine("Unmanaged Packet " + p.g7().ToString());
            }
        }
    }

    public static void a(p A_0)
    {
        a.Enqueue(A_0);
        b.Set();
    }

    [CompilerGenerated]
    private static Clan a(KeyValuePair<uint, Clan> A_0)
    {
        return A_0.Value;
    }

    public void b()
    {
        new aj.a(this.a).BeginInvoke(null, null);
        this.c = true;
        Console.WriteLine("DataProcessor started");
    }

    [CompilerGenerated]
    private static uint b(KeyValuePair<uint, Clan> A_0)
    {
        return A_0.Key;
    }

    private delegate void a();

    [CompilerGenerated]
    private sealed class b
    {
        public v a;

        public bool b(Clan A_0)
        {
            return A_0.ClanName.ToLower().Contains(this.a.f1().ToLower());
        }
    }
}

