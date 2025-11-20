using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using System;

namespace Services.Customers.Infrastructure.Persistence.Serializers
{
    public class DateTimeSerializerProvider : IBsonSerializationProvider
    {
        public IBsonSerializer GetSerializer(Type type)
        {
            return type == typeof(DateTime) ? DateTimeSerializer.LocalInstance : null;
        }
    }
}