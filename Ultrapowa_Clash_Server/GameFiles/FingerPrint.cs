namespace Ultrapowa_Clash_Server.GameFiles
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    internal class FingerPrint
    {
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this).Replace("/", @"\/");
        }

        public List<GameFile> files { get; set; }

        public string sha { get; set; }

        public string version { get; set; }
    }
}

