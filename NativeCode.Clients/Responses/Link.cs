﻿namespace NativeCode.Clients.Responses
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Link
    {
        [DataMember]
        public string Href { get; protected set; }
    }
}