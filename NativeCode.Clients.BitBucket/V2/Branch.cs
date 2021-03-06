﻿namespace NativeCode.Clients.BitBucket.V2
{
    using System.Runtime.Serialization;
    using JsonExtensions;
    using Newtonsoft.Json;

    [DataContract]
    public class Branch
    {
        [DataMember]
        public string Name { get; protected set; }

        [DataMember]
        public Target Target { get; protected set; }

        [DataMember]
        [JsonConverter(typeof(EnumJsonConverter))]
        public ResourceType Type { get; protected set; }
    }
}