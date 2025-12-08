using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using System;

namespace Services.Customers.Infrastructure.Persistence.Serializers
{
    public class GuidSerializerProvider : IBsonSerializationProvider
    {
        public IBsonSerializer GetSerializer(Type type)
        {
            return type == typeof(Guid) ? new GuidSerializer(GuidRepresentation.Standard) : null;
        }
    }
}