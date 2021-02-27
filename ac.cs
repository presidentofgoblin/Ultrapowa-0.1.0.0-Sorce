using FileHelpers;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Ultrapowa_Clash_Server.Database;
using Ultrapowa_Clash_Server.GameFiles;
using Ultrapowa_Clash_Server.World;

internal class ac
{
    public Timer a;
    public bool b = false;
    [CompilerGenerated]
    private static ConcurrentDictionary<af, Ultrapowa_Clash_Server.World.Player> c;
    [CompilerGenerated]
    private static ConcurrentDictionary<Ultrapowa_Clash_Server.World.Player, af> d;
    [CompilerGenerated]
    private static ConcurrentDictionary<uint, Ultrapowa_Clash_Server.World.Player> e;
    [CompilerGenerated]
    private static ConcurrentDictionary<Socket, af> f;
    [CompilerGenerated]
    private static ConcurrentDictionary<uint, Ultrapowa_Clash_Server.World.Clan> g;
    [CompilerGenerated]
    private static Dictionary<Tuple<uint, int>, Building> h;
    [CompilerGenerated]
    private static FingerPrint i;
    [CompilerGenerated]
    private static Func<Building, string> j;
    [CompilerGenerated]
    private static Func<BuildingMap, string> k;
    [CompilerGenerated]
    private static Func<Building, BuildingMap, <>f__AnonymousType0<uint, int, Building>> l;

    public ac()
    {
        c(new ConcurrentDictionary<Socket, af>());
        c(new ConcurrentDictionary<af, Ultrapowa_Clash_Server.World.Player>());
        c(new ConcurrentDictionary<Ultrapowa_Clash_Server.World.Player, af>());
        c(new ConcurrentDictionary<uint, Ultrapowa_Clash_Server.World.Player>());
        c(new ConcurrentDictionary<uint, Ultrapowa_Clash_Server.World.Clan>());
        c(new Dictionary<Tuple<uint, int>, Building>());
        n();
        o();
        m();
        TimerCallback callback = new TimerCallback(this.c);
        Timer timer = new Timer(callback, null, 0xea60, 0xea60);
        this.a = timer;
        Console.WriteLine("ObjectManager: synchronization started");
    }

    [CompilerGenerated]
    public static FingerPrint c()
    {
        return i;
    }

    public static Ultrapowa_Clash_Server.World.Player c(af A_0)
    {
        Ultrapowa_Clash_Server.World.Player player;
        i().TryGetValue(A_0, ref player);
        return player;
    }

    [CompilerGenerated]
    public static void c(ConcurrentDictionary<af, Ultrapowa_Clash_Server.World.Player> A_0)
    {
        c = A_0;
    }

    public static Ultrapowa_Clash_Server.World.Player c(uint A_0)
    {
        ac.a a = new ac.a {
            a = A_0
        };
        Ultrapowa_Clash_Server.World.Player player = null;
        g().TryGetValue(a.a, ref player);
        if (player == null)
        {
            ucsdbEntities entities = new ucsdbEntities();
            IQueryable<string> queryable = from p in entities.Player
                where p.PlayerId == ((int) a.a)
                select p.SerializedData;
            if (Queryable.Count<string>(queryable) > 0)
            {
                player = JsonConvert.DeserializeObject<Ultrapowa_Clash_Server.World.Player>(Queryable.First<string>(queryable));
                g().TryAdd(a.a, player);
            }
        }
        return player;
    }

    [CompilerGenerated]
    public static void c(ConcurrentDictionary<Socket, af> A_0)
    {
        f = A_0;
    }

    [CompilerGenerated]
    public static void c(ConcurrentDictionary<uint, Ultrapowa_Clash_Server.World.Clan> A_0)
    {
        g = A_0;
    }

    [CompilerGenerated]
    public static void c(ConcurrentDictionary<uint, Ultrapowa_Clash_Server.World.Player> A_0)
    {
        e = A_0;
    }

    private void c(object A_0)
    {
        k();
        j();
        if (this.b)
        {
            this.a.Dispose();
        }
    }

    [CompilerGenerated]
    public static void c(ConcurrentDictionary<Ultrapowa_Clash_Server.World.Player, af> A_0)
    {
        d = A_0;
    }

    [CompilerGenerated]
    public static void c(FingerPrint A_0)
    {
        i = A_0;
    }

    [CompilerGenerated]
    private static string c(Building A_0)
    {
        return A_0.ExportName;
    }

    [CompilerGenerated]
    private static string c(BuildingMap A_0)
    {
        return A_0.ExportName;
    }

    [CompilerGenerated]
    public static void c(Dictionary<Tuple<uint, int>, Building> A_0)
    {
        h = A_0;
    }

    [CompilerGenerated]
    private static <>f__AnonymousType0<uint, int, Building> c(Building A_0, BuildingMap A_1)
    {
        return new { BuildingId = A_1.BuildingId, BuildingLevel = A_1.BuildingLevel, building = A_0 };
    }

    public static void c(Ultrapowa_Clash_Server.World.Player A_0, af A_1)
    {
        af af = null;
        Ultrapowa_Clash_Server.World.Player player = null;
        g().TryAdd(A_0.PlayerId, A_0);
        h().TryRemove(A_0, ref af);
        if (af != null)
        {
            Socket introduced2 = af.f();
            f().TryRemove(introduced2, ref af);
            try
            {
                af.f().Shutdown(SocketShutdown.Both);
                af.f().Close();
            }
            catch (SocketException)
            {
                af.e((Socket) null);
            }
        }
        h().GetOrAdd(A_0, A_1);
        i().TryRemove(A_1, ref player);
        i().GetOrAdd(A_1, A_0);
    }

    [CompilerGenerated]
    public static Dictionary<Tuple<uint, int>, Building> d()
    {
        return h;
    }

    [CompilerGenerated]
    public static ConcurrentDictionary<uint, Ultrapowa_Clash_Server.World.Clan> e()
    {
        return g;
    }

    [CompilerGenerated]
    public static ConcurrentDictionary<Socket, af> f()
    {
        return f;
    }

    [CompilerGenerated]
    public static ConcurrentDictionary<uint, Ultrapowa_Clash_Server.World.Player> g()
    {
        return e;
    }

    [CompilerGenerated]
    public static ConcurrentDictionary<Ultrapowa_Clash_Server.World.Player, af> h()
    {
        return d;
    }

    [CompilerGenerated]
    public static ConcurrentDictionary<af, Ultrapowa_Clash_Server.World.Player> i()
    {
        return c;
    }

    public static void j()
    {
        Console.WriteLine("Starting saving clans from memory to database at " + DateTime.Now.ToString());
        ucsdbEntities entities = new ucsdbEntities();
        foreach (KeyValuePair<uint, Ultrapowa_Clash_Server.World.Clan> pair in e())
        {
            Ultrapowa_Clash_Server.Database.Clan clan;
            lock (pair.Value)
            {
                clan = new Ultrapowa_Clash_Server.Database.Clan {
                    ClanId = (int) pair.Value.ClanId,
                    LastUpdateTime = DateTime.Now,
                    SerializedData = JsonConvert.SerializeObject(pair.Value)
                };
            }
            entities.Clan.Add(clan);
            entities.SaveChanges();
        }
        Console.WriteLine("Finished saving clans from memory to database at " + DateTime.Now.ToString());
    }

    public static void k()
    {
        Console.WriteLine("Starting saving players from memory to database at " + DateTime.Now.ToString());
        ucsdbEntities entities = new ucsdbEntities();
        foreach (KeyValuePair<uint, Ultrapowa_Clash_Server.World.Player> pair in g())
        {
            Ultrapowa_Clash_Server.Database.Player player;
            lock (pair.Value)
            {
                player = new Ultrapowa_Clash_Server.Database.Player {
                    PlayerId = (int) pair.Value.PlayerId,
                    LastUpdateTime = DateTime.Now,
                    SerializedData = JsonConvert.SerializeObject(pair.Value)
                };
            }
            entities.Player.Add(player);
            entities.SaveChanges();
        }
        Console.WriteLine("Finished saving players from memory to database at " + DateTime.Now.ToString());
    }

    public static uint l()
    {
        ucsdbEntities entities = new ucsdbEntities();
        int num = 0;
        lock (entities)
        {
            ParameterExpression expression;
            num = Queryable.Max<int>(Queryable.DefaultIfEmpty<int>(Queryable.Select<Ultrapowa_Clash_Server.Database.Player, int>(entities.Player, Expression.Lambda<Func<Ultrapowa_Clash_Server.Database.Player, int>>(Expression.Coalesce(Expression.Convert(Expression.Property(expression = Expression.Parameter(typeof(Ultrapowa_Clash_Server.Database.Player), "ep"), (MethodInfo) methodof(Ultrapowa_Clash_Server.Database.Player.get_PlayerId)), typeof(int?)), Expression.Constant(0, typeof(int))), new ParameterExpression[] { expression }))));
            Ultrapowa_Clash_Server.Database.Player entity = new Ultrapowa_Clash_Server.Database.Player {
                PlayerId = num + 1,
                LastUpdateTime = DateTime.Now,
                SerializedData = string.Empty
            };
            entities.Player.Add(entity);
            entities.SaveChanges();
        }
        return (uint) (num + 1);
    }

    public static void m()
    {
        FileHelperEngine engine = new FileHelperEngine(typeof(Building));
        Building[] buildingArray = engine.ReadFile(ConfigurationManager.AppSettings["buildings"]) as Building[];
        engine = new FileHelperEngine(typeof(BuildingMap));
        BuildingMap[] mapArray = engine.ReadFile(ConfigurationManager.AppSettings["buildingsMap"]) as BuildingMap[];
        if (j == null)
        {
            j = new Func<Building, string>(null, (IntPtr) c);
        }
        if (k == null)
        {
            k = new Func<BuildingMap, string>(null, (IntPtr) c);
        }
        if (l == null)
        {
            l = new Func<Building, BuildingMap, <>f__AnonymousType0<uint, int, Building>>(null, (IntPtr) c);
        }
        foreach (var type in Enumerable.Join(buildingArray, mapArray, j, k, l))
        {
            d().Add(Tuple.Create<uint, int>(type.BuildingId, type.BuildingLevel), type.building);
        }
        Console.WriteLine("ObjectManager: buildings loaded");
    }

    public static void n()
    {
        StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["fingerPrint"]);
        string str = reader.ReadToEnd();
        reader.Close();
        c(JsonConvert.DeserializeObject<FingerPrint>(str));
        Console.WriteLine("ObjectManager: fingerprint loaded");
    }

    public static void o()
    {
        ucsdbEntities entities = new ucsdbEntities();
        foreach (string str in from p in entities.Clan select p.SerializedData)
        {
            Ultrapowa_Clash_Server.World.Clan clan = JsonConvert.DeserializeObject<Ultrapowa_Clash_Server.World.Clan>(str);
            e().TryAdd(clan.ClanId, clan);
        }
        Console.WriteLine("ObjectManager: clans loaded");
    }

    [CompilerGenerated]
    private sealed class a
    {
        public uint a;
    }
}

