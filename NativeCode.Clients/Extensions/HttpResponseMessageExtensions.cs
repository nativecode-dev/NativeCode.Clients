﻿namespace NativeCode.Clients.Extensions
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using JetBrains.Annotations;
    using Newtonsoft.Json;

    public static class HttpResponseMessageExtensions
    {
        public static async Task<T> DeserializeAsync<T>([NotNull] this HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode == false || response.Content.IsJson() == false)
            {
                throw new InvalidOperationException("Invalid request parameters to deserialize.");
            }

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<T>(content, SerializationOptions.Settings);
        }
    }
}