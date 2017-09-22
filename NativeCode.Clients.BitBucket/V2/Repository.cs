﻿namespace NativeCode.Clients.BitBucket.V2
{
    using System;
    using System.Runtime.Serialization;
    using JsonExtensions;
    using Newtonsoft.Json;

    [DataContract]
    public class Repository
    {
        [DataMember]
        public string FullName { get; protected set; }

        [DataMember]
        public string Name { get; protected set; }

        [DataMember]
        [JsonConverter(typeof(EnumJsonConverter))]
        public ResourceType Type { get; protected set; }

        [DataMember]
        public Guid Uuid { get; protected set; }
    }
}