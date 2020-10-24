using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chatinator.Shared.Packets
{
    public class PacketSerializer
    {
        readonly JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Auto,
        };

        public string Serialize(Payload payload)
        {
            var packet = new Packet
            {
                Payload = payload,
            };

            return JsonConvert.SerializeObject(packet, _jsonSerializerSettings);
        }

        public Payload Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<Packet>(json, _jsonSerializerSettings).Payload;
        }
    }
}
