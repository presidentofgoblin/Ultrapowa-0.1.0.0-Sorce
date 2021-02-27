namespace Ultrapowa_Clash_Server.Helpers
{
    using Newtonsoft.Json;
    using System;

    public static class ObjectCopier
    {
        public static T Clone<T>(T source)
        {
            if (object.ReferenceEquals(source, null))
            {
                return default(T);
            }
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(source));
        }
    }
}

